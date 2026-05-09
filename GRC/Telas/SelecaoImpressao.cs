using Data.Models;
using GRC.Properties;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iText.Layout.Element.Image;


namespace GRC.Telas
{
    public partial class SelecaoImpressao : Form
    {
        List<OrdemServico> _os = new List<OrdemServico>();

        PdfFont _bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
        PdfFont _regular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

        private const float FontSizeBase = 9f;

        private string _totalGeralServico = null;
        public SelecaoImpressao(List<OrdemServico> ordemServico, string total = "")
        {
            InitializeComponent();
            _os = ordemServico;
            _totalGeralServico = total;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                var osPrincipal = _os.FirstOrDefault();
                // Define o sufixo baseado no tipo de documento
                string tipoDoc = rbEntrada.Checked ? "ENTRADA" : "SAIDA";
                string nomeBase = $"{DateTime.Today:dd-MM-yy}_{osPrincipal.Id}_{tipoDoc}_{osPrincipal.DadosCliente.Nome}";

                sfd.Title = "Selecione onde salvar o PDF da Ordem de Serviço";
                sfd.FileName = nomeBase;
                sfd.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoOriginal = sfd.FileName;

                    // Gera o PDF passando se é via de Entrada ou não
                    GerarPdfOrdemServico(caminhoOriginal, rbEntrada.Checked);

                    new AlertBox(System.Drawing.Color.FromArgb(0, 60, 4), System.Drawing.Color.LimeGreen, System.Drawing.Color.Green, Resources.Confirm, "Exportação da OS", $"PDF do cliente: {osPrincipal.DadosCliente.Nome}", "Foi gerado com sucesso! Abrindo o documento...", false).ShowDialog();

                    // Lógica de Impressão
                    if (rbPdfImp.Checked)
                    {
                        if (new AlertBox(System.Drawing.Color.FromArgb(0, 60, 4), System.Drawing.Color.LimeGreen, System.Drawing.Color.Green, Resources.Confirm,
                            "Impressão", "O PDF já pode ser impresso.", "Deseja imprimir agora?", true).ShowDialog() == DialogResult.Yes)
                        {
                            ExecutarImpressao(caminhoOriginal);
                        }
                    }
                }
            }
        }
       
        private void SelecaoImpressao_Load(object sender, EventArgs e)
        {
           int idcliente = _os.FirstOrDefault().DadosCliente.Id;
            rbEntrada.Checked = true;
            rbPdf.Checked = true;
        }
        public void GerarPdfOrdemServico(string caminhoArquivo, bool ehEntrada)
        {
            DadosLoja dadosLoja = new DadosLoja();

            using (var writer = new PdfWriter(caminhoArquivo))
            using (var pdf = new PdfDocument(writer))
            {
                var doc = new Document(pdf, PageSize.A4);
                doc.SetMargins(25, 25, 25, 25);

                foreach (var os in _os)
                {
                    AdicionarCabecalho(doc, dadosLoja);
                    AdicionarTitulo(doc, os, ehEntrada);
                    AdicionarDadosCliente(doc, os);

                    if (ehEntrada) MontarLayoutEntrada(doc, os);
                    else MontarLayoutSaida(doc, os);
                }
                doc.Close();
            }
            Process.Start(new ProcessStartInfo(caminhoArquivo) { UseShellExecute = true });
        }

        private void MontarLayoutEntrada(Document doc, OrdemServico os)
        {
            Table tabelaEntrada = new Table(new float[] { 1, 1 }).UseAllAvailableWidth().SetMarginTop(10);

            // Linha 1: Datas e Controle
            tabelaEntrada.AddCell(CriarCelulaLabelValue("DATA ENTRADA", os.DataEntrada ?? "---", FontSizeBase));
            tabelaEntrada.AddCell(CriarCelulaLabelValue("Nº CONTROLE", os.Id.ToString().PadLeft(6, '0'), FontSizeBase));

            // Linha 2: Previsão e Senha
            tabelaEntrada.AddCell(CriarCelulaLabelValue("PREVISÃO DE TÉRMINO", os.FimPrevisto ?? "A combinar", FontSizeBase));
            tabelaEntrada.AddCell(CriarCelulaLabelValue("SENHA DO APARELHO", "", FontSizeBase));

            doc.Add(tabelaEntrada);

            // Descrição do Problema
            Table tabelaDesc = new Table(1).UseAllAvailableWidth().SetMarginTop(10);
            tabelaDesc.AddCell(CriarCelulaGrande("AVARIA RELATADA / SINTOMAS", os.DescricaoProblema ?? "Não informado", FontSizeBase));

            if (!string.IsNullOrWhiteSpace(os.ObservacoesCliente))
                tabelaDesc.AddCell(CriarCelulaGrande("OBSERVAÇÕES DO CLIENTE", os.ObservacoesCliente, FontSizeBase));

            doc.Add(tabelaDesc);
            doc.Add(new Paragraph("\n"));
            AdicionarTermoCiencia(doc);
            AdicionarAssinaturas(doc);
        }

        private void MontarLayoutSaida(Document doc, OrdemServico os)
        {
            Table tabelaSaida = new Table(new float[] { 1, 1, 1 }).UseAllAvailableWidth().SetMarginTop(10);

            // Linha 1: Datas e Controle
            tabelaSaida.AddCell(CriarCelulaLabelValue("DATA ENTRADA", os.DataEntrada ?? "---", FontSizeBase));
            tabelaSaida.AddCell(CriarCelulaLabelValue("DATA SAÍDA", os.FimReal ?? DateTime.Now.ToString("dd/MM/yyyy"), FontSizeBase));
            tabelaSaida.AddCell(CriarCelulaLabelValue("Nº CONTROLE", os.Id.ToString().PadLeft(6, '0'), FontSizeBase));

            // Linha 2: Garantia
            tabelaSaida.AddCell(CriarCelulaLabelValue("INÍCIO GARANTIA", os.InicioGarantia ?? os.FimReal, FontSizeBase));
            tabelaSaida.AddCell(CriarCelulaLabelValue("FIM GARANTIA", os.FimGarantia ?? "---", FontSizeBase));
            tabelaSaida.AddCell(CriarCelulaLabelValue("VIGÊNCIA", $"{os.Garantia} DIAS", FontSizeBase));

            doc.Add(tabelaSaida);

            // Descrição Técnica
            Table tabelaTec = new Table(1).UseAllAvailableWidth().SetMarginTop(10);
            tabelaTec.AddCell(CriarCelulaGrande("SOLUÇÃO TÉCNICA / SERVIÇOS EXECUTADOS", os.DescricaoSolucao ?? "Reparo concluído.", FontSizeBase));

            if (!string.IsNullOrWhiteSpace(os.ObservacoesCliente))
                tabelaTec.AddCell(CriarCelulaGrande("OBSERVAÇÕES ADICIONAIS", os.ObservacoesCliente, FontSizeBase));

            doc.Add(tabelaTec);

            AdicionarTotais(doc, os);
            doc.Add(new Paragraph("\n"));
            AdicionarTermoGarantia(doc);
            AdicionarAssinaturas(doc);
        }

        #region Componentes de Layout Reutilizáveis
        private Cell CriarCelulaLabelValue(string label, string value, float fontSize)
        {
            return new Cell().SetPadding(5).SetBorder(new SolidBorder(0.5f))
                .Add(new Paragraph(label).SetFontSize(fontSize - 2.5f).SetFont(_bold).SetFontColor(ColorConstants.GRAY).SetMarginBottom(-2))
                .Add(new Paragraph(value ?? "---").SetFontSize(fontSize).SetFont(_regular));
        }

        private Cell CriarCelulaGrande(string label, string content, float fontSize)
        {
            return new Cell().SetPadding(6).SetBorder(new SolidBorder(0.5f))
                .Add(new Paragraph(label).SetFontSize(fontSize - 2.5f).SetFont(_bold).SetFontColor(ColorConstants.GRAY).SetMarginBottom(2))
                .Add(new Paragraph(content).SetFontSize(fontSize).SetFont(_regular).SetMultipliedLeading(1.1f));
        }

        private void AdicionarCabecalho(Document doc, DadosLoja loja)
        {
            var table = new Table(new float[] { 1, 3 }).UseAllAvailableWidth();
            var logoBytes = BitmapToBytes(Properties.Resources.RF_LabTech_Logo);
            table.AddCell(new Cell().Add(new Image(ImageDataFactory.Create(logoBytes)).SetWidth(110)).SetBorder(Border.NO_BORDER));

            table.AddCell(new Cell().Add(new Paragraph(loja.Nome).SetFont(_bold).SetFontSize(12))
                .Add(new Paragraph($"{loja.Endereco}\nCNPJ: {loja.Cnpj} | Tel: {loja.Telefone}").SetFontSize(8))
                .SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE));

            doc.Add(table);
            doc.Add(new LineSeparator(new SolidLine(0.5f)).SetMarginTop(5).SetMarginBottom(5));
        }

        private void AdicionarTitulo(Document doc, OrdemServico os, bool ehEntrada)
        {
            string texto = ehEntrada ? "ORDEM DE SERVIÇO - ENTRADA" : "ORDEM DE SERVIÇO - SAÍDA";
            doc.Add(new Paragraph(texto).SetFont(_bold).SetFontSize(11).SetBackgroundColor(new DeviceRgb(40, 40, 40))
                .SetFontColor(ColorConstants.WHITE).SetPaddingLeft(10).SetPaddingTop(2).SetPaddingBottom(2));
        }

        private void AdicionarDadosCliente(Document doc, OrdemServico os)
        {
            Table table = new Table(new float[] { 3, 2 }).UseAllAvailableWidth().SetMarginTop(5);
            string tels = os.DadosCliente.Telefones?.Any() == true ? string.Join(" / ", os.DadosCliente.Telefones.Select(t => t.Descricao)) : "---";

            table.AddCell(new Cell().Add(new Paragraph().Add(new Text("CLIENTE: ").SetFont(_bold)).Add(new Text(os.DadosCliente.Nome.ToUpper())))
                .Add(new Paragraph().Add(new Text("TEL: ").SetFont(_bold)).Add(new Text(tels))).SetBorder(Border.NO_BORDER).SetFontSize(9));

            table.AddCell(new Cell().Add(new Paragraph().Add(new Text("CPF/CNPJ: ").SetFont(_bold)).Add(new Text(os.DadosCliente.Identidade ?? "---")))
                .SetBorder(Border.NO_BORDER).SetFontSize(9).SetTextAlignment(TextAlignment.RIGHT));

            doc.Add(table);
            doc.Add(new LineSeparator(new SolidLine(0.5f)).SetMarginBottom(10));
        }

        private void AdicionarTotais(Document doc, OrdemServico os)
        {
            if (_totalGeralServico != null)
            {
                Table table = new Table(1).SetWidth(UnitValue.CreatePercentValue(35)).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT).SetMarginTop(10);
                table.AddCell(new Cell().SetPadding(8).SetBackgroundColor(new DeviceRgb(240, 240, 240))
                    .Add(new Paragraph("VALOR TOTAL").SetFontSize(7).SetFont(_bold).SetFontColor(ColorConstants.GRAY).SetMarginBottom(-2))
                    .Add(new Paragraph($"{_totalGeralServico}").SetFont(_bold).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT)));
                doc.Add(table);
            }
        }

        private void AdicionarAssinaturas(Document doc)
        {
            doc.Add(new Paragraph("\n\n"));
            Table table = new Table(2).UseAllAvailableWidth();
            string linha = "_________________________________";

            table.AddCell(new Cell().Add(new Paragraph(linha + "\nAssinatura do Cliente").SetFont(_bold).SetFontSize(9)).SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER));
            table.AddCell(new Cell().Add(new Paragraph(linha + "\nResponsável Técnico").SetFont(_bold).SetFontSize(9)).SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER));

            doc.Add(table);
        }
        #endregion

        #region Termos Legais
        private void AdicionarTermoCiencia(Document doc)
        {
            doc.Add(new Paragraph("TERMOS DE RECEBIMENTO").SetFont(_bold).SetFontSize(10));
            string termo = "1. Orçamento sem compromisso. 2. A garantia de 90 dias cobre apenas o serviço realizado. " +
                           "3. Aparelhos e qualquer outro item não retirados em 90 dias serão descartados nos termos do Art. 1.275 do CC.";
            doc.Add(new Paragraph(termo).SetFontSize(8.5f).SetTextAlignment(TextAlignment.JUSTIFIED).SetMultipliedLeading(1.0f));
        }

        private void AdicionarTermoGarantia(Document doc)
        {
            doc.Add(new Paragraph("CERTIFICADO DE GARANTIA").SetFont(_bold).SetFontSize(10));
            string termo = "Garantimos este serviço por 90 dias. A garantia é anulada em caso de: quedas, contato com líquidos, " +
                           "violação de selos ou reparos por terceiros.";
            doc.Add(new Paragraph(termo).SetFontSize(8.5f).SetTextAlignment(TextAlignment.JUSTIFIED));
        }
        #endregion

        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            using (var ms = new MemoryStream())
            {
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

       
        private void ExecutarImpressao(string caminho)
        {
            using (PrintDialog pd = new PrintDialog())
            {
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    ProcessStartInfo info = new ProcessStartInfo { Verb = "print", FileName = caminho, CreateNoWindow = true, WindowStyle = ProcessWindowStyle.Hidden };
                    Process.Start(info);
                }
            }
        }
        // Importar as DLLs do Windows para mover o formulário
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes para a mensagem de movimento
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void SelecaoImpressao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Libera o mouse para a operação
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Envia comando de mover
            }
        }
    }

}
