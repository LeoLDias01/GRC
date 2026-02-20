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
        public SelecaoImpressao(List<OrdemServico> ordemServico)
        {
            InitializeComponent();
            _os = ordemServico;
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
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4);
                    doc.SetMargins(20, 20, 20, 20);

                    foreach (var os in _os)
                    {
                        AdicionarCabecalho(doc, dadosLoja);
                        AdicionarTitulo(doc, os, ehEntrada);
                        AdicionarDadosCliente(doc, os);

                        if (ehEntrada)
                        {
                            MontarLayoutEntrada(doc, os);
                        }
                        else
                        {
                            MontarLayoutSaida(doc, os);
                        }
                    }
                    doc.Close();
                }
            }
            Process.Start(new ProcessStartInfo(caminhoArquivo) { UseShellExecute = true });
        }

        private void MontarLayoutEntrada(Document doc, OrdemServico os)
        {
            // Título com margem inferior para não "colar" no conteúdo
            var title = new Paragraph("RELATÓRIO DE ENTRADA / CHECK-IN")
                .SetFont(_bold)
                .SetFontSize(12)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetPadding(5)
                .SetMarginBottom(15);
            doc.Add(title);

            // Definindo um espaçamento entre linhas (Leading) maior para todo o bloco
            float espacamentoEntreLinhas = 1.7f;

            // 1. Avaria Relatada
            doc.Add(new Paragraph()
                .Add(new Text("Avaria Relatada: ").SetFont(_bold))
                .Add(new Text(os.DescricaoProblema ?? "Não informado").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas)
                .SetMarginBottom(10));

            // 2. Senha do Aparelho (com linha pontilhada fina até o final da página)
            doc.Add(new Paragraph()
                .Add(new Text("Senha do Aparelho: ").SetFont(_bold))
                .Add(new Tab())
                .AddTabStops(new TabStop(1000, iText.Layout.Properties.TabAlignment.LEFT, new DottedLine(0.5f))) // 0.5f deixa bem fininho
                .SetMultipliedLeading(espacamentoEntreLinhas)
                .SetMarginBottom(10));
            // 3. Datas
            doc.Add(new Paragraph()
                .Add(new Text("Data de Entrada: ").SetFont(_bold))
                .Add(new Text(os.DataEntrada).SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas));

            doc.Add(new Paragraph()
                .Add(new Text("Previsão de Término: ").SetFont(_bold))
                .Add(new Text(os.FimPrevisto ?? "A combinar").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas)
                .SetMarginBottom(15));

            // 4. Observações com recuo e espaçamento
            if (!string.IsNullOrWhiteSpace(os.ObservacoesCliente))
            {
                doc.Add(new Paragraph().Add(new Text("Observações:").SetFont(_bold)).SetMarginBottom(5));
                doc.Add(new Paragraph(os.ObservacoesCliente)
                    .SetFontSize(10)
                    .SetFont(_regular)
                    .SetMultipliedLeading(espacamentoEntreLinhas)
                    .SetMarginBottom(20));
            }

            // Adiciona uma separação visual antes do termo
            doc.Add(new LineSeparator(new DashedLine(0.5f)));
            doc.Add(new Paragraph("\n").SetFixedLeading(10f));

            AdicionarTermoCiencia(doc);
            AdicionarAssinaturas(doc);
        }

        private void MontarLayoutSaida(Document doc, OrdemServico os)
        {
            float espacamentoEntreLinhas = 1.7f;

            // 1. Solução Técnica (Substituindo descrição do problema)
            doc.Add(new Paragraph()
                .Add(new Text("Solução Técnica / Serviço Realizado: ").SetFont(_bold))
                .Add(new Text(os.DescricaoSolucao ?? "Manutenção técnica concluída.").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas)
                .SetMarginBottom(15));

            // 2. Bloco de Garantia (Cálculo de dias e datas)

            doc.Add(new Paragraph()
                .Add(new Text("Data de Entrada: ").SetFont(_bold))
                .Add(new Text(os.DataEntrada ?? "---").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas));
            doc.Add(new Paragraph()
                .Add(new Text("Data de Término: ").SetFont(_bold))
                .Add(new Text(os.FimReal ?? "---").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas));

            doc.Add(new Paragraph()
                .Add(new Text("Período de Garantia: ").SetFont(_bold))
                .Add(new Text($"{os.InicioGarantia} até {os.FimGarantia}").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas));

            doc.Add(new Paragraph()
                .Add(new Text("Vigência: ").SetFont(_bold))
                .Add(new Text($"{os.Garantia} dias").SetFont(_regular))
                .SetMultipliedLeading(espacamentoEntreLinhas)
                .SetMarginBottom(20));

            // 3. Tabelas de Itens e Valores (conforme seu original)
            AdicionarItens(doc, os);
            AdicionarTotais(doc, os);

            doc.Add(new Paragraph("\n"));
            doc.Add(new LineSeparator(new SolidLine(0.5f)));

            // Termo de Saída e Assinaturas (Mantidos iguais)
            AdicionarTermoGarantiaDirecionado(doc, os);
            AdicionarAssinaturas(doc);
        }

        private void AdicionarTermoGarantiaDirecionado(Document doc, OrdemServico os)
        {
            doc.Add(new Paragraph("CERTIFICADO DE GARANTIA").SetFont(_bold).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER).SetMultipliedLeading(1.7f));

            string dtInicio = DateTime.Now.ToShortDateString();
            string dtFim = DateTime.Now.AddDays(90).ToShortDateString(); // Exemplo 90 dias

            string texto = $"Pelo presente termo, a empresa garante a qualidade do serviço realizado: ({os.DescricaoSolucao}), " +
                           $"pelo período legal de 90 dias, iniciando em {dtInicio} e com término em {dtFim}. " +
                           "\n\nA garantia NÃO cobre: Quedas, contato com líquidos, selos de garantia rompidos ou reparos por terceiros.";

            doc.Add(new Table(1).UseAllAvailableWidth().AddCell(new Cell().Add(new Paragraph(texto).SetTextAlignment(TextAlignment.JUSTIFIED)).SetPadding(10)));
        }

        private void AdicionarCabecalho(Document doc, DadosLoja loja)
        {
            var table = new Table(new float[] { 1.5f, 5 })
                .UseAllAvailableWidth();

            // LOGO (Resources)
            var logoBytes = BitmapToBytes(Properties.Resources.RF_LabTech_Logo);
            var logo = new Image(ImageDataFactory.Create(logoBytes))
                .SetWidth(125);

            table.AddCell(new Cell()
                .Add(logo)
                .SetBorder(Border.NO_BORDER));

            table.AddCell(new Cell()
                .Add(new Paragraph(loja.Nome))
                .Add(new Paragraph($"CNPJ: {loja.Cnpj}"))
                .Add(new Paragraph($"Telefone: {loja.Telefone}"))
                .Add(new Paragraph(loja.Endereco))
                .SetBorder(Border.NO_BORDER));

            doc.Add(table);
            doc.Add(new Paragraph("\n"));
            var line = new SolidLine();
            line.SetLineWidth(0.3f); // espessura da linha (quanto menor, mais fina)
            var separator = new LineSeparator(line); 
        }
        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private void AdicionarTitulo(Document doc, OrdemServico os, bool ehEntrada)
        {
            // Define o texto e a cor com base no tipo
            string textoTitulo = ehEntrada ? "ORDEM DE SERVIÇO" : "COMPROVANTE DE ENTREGA";

            // Criar uma tabela de uma célula para fazer o efeito de "faixa" no título
            Table tituloTabela = new Table(1).UseAllAvailableWidth();

            Cell celulaTitulo = new Cell()
                .Add(new Paragraph(textoTitulo)
                    .SetFont(_bold)
                    .SetFontSize(14)
                    .SetFontColor(ColorConstants.BLACK))
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBackgroundColor(new DeviceRgb(240, 240, 240)) // Cinza bem clarinho
                .SetBorder(new SolidBorder(0.5f));

            tituloTabela.AddCell(celulaTitulo);
            doc.Add(tituloTabela);

            // Linha de informações rápidas logo abaixo do título
            var infoRapida = new Paragraph()
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(9)
                .Add(new Text($"Nº CONTROLE: ").SetFont(_bold))
                .Add(new Text(os.Id.ToString().PadLeft(6, '0')).SetFont(_regular))
                .Add(new Text("  |  ").SetFont(_bold))
                .Add(new Text($"EMISSÃO: ").SetFont(_bold))
                .Add(new Text(DateTime.Now.ToString("dd/MM/yyyy HH:mm")).SetFont(_regular));

            doc.Add(infoRapida);
            doc.Add(new Paragraph("\n").SetFixedLeading(5f));
        }
        private void AdicionarDadosCliente(Document doc, OrdemServico os)
        {
            // Tabela de 2 colunas para economizar espaço vertical
            var table = new Table(new float[] { 3, 2 }).UseAllAvailableWidth();

            string telefones = (os.DadosCliente.Telefones != null && os.DadosCliente.Telefones.Any())
                ? string.Join(" / ", os.DadosCliente.Telefones.Select(t => t.Descricao))
                : "N/A";

            // Coluna 1: Nome e Telefones
            table.AddCell(new Cell().SetBorder(Border.NO_BORDER)
                .Add(new Paragraph().Add(new Text("CLIENTE: ").SetFont(_bold)).Add(new Text(os.DadosCliente.Nome.ToUpper()).SetFont(_regular)))
                .Add(new Paragraph().Add(new Text("TEL: ").SetFont(_bold)).Add(new Text(telefones).SetFont(_regular))));

            // Coluna 2: CPF/CNPJ
            table.AddCell(new Cell().SetBorder(Border.NO_BORDER)
                .Add(new Paragraph().Add(new Text("CPF/CNPJ: ").SetFont(_bold)).Add(new Text(os.DadosCliente.Identidade ?? "---").SetFont(_regular))));

            doc.Add(table);
            doc.Add(new LineSeparator(new SolidLine(0.5f)));
            doc.Add(new Paragraph("\n").SetFixedLeading(5f)); // Espaçamento mínimo
        }
        private void AdicionarItens(Document doc, OrdemServico os)
        {
            float espacamentoEntreLinhas = 1.7f;

            // 1. Serviço Realizado (Solução)
            if (!string.IsNullOrWhiteSpace(os.DescricaoSolucao))
            {
                doc.Add(new Paragraph()
                    .Add(new Text("Serviço realizado: ").SetFont(_bold))
                    .Add(new Text(os.DescricaoSolucao).SetFont(_regular))
                    .SetMultipliedLeading(espacamentoEntreLinhas)
                    .SetMarginBottom(10));
            }

            // 2. Observações do Cliente
            if (!string.IsNullOrWhiteSpace(os.ObservacoesCliente))
            {
                doc.Add(new Paragraph()
                    .Add(new Text("Observações: ").SetFont(_bold))
                    .Add(new Text(os.ObservacoesCliente).SetFont(_regular))
                    .SetMultipliedLeading(espacamentoEntreLinhas)
                    .SetMarginBottom(10));
            }
        }
        private void AdicionarTotais(Document doc, OrdemServico os)
        {
            var line = new SolidLine(0.1f);
            var separator = new LineSeparator(line);

            decimal total = os.ItensOrdemServico.Sum(i => i.Subtotal);

            doc.Add(separator);
            doc.Add(new Paragraph($"Total de Peças: {total:C2}").SetMultipliedLeading(1.7f));
        }

        private void AdicionarAssinaturas(Document doc)
        {
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont regular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            doc.Add(new Paragraph("\n\n"));

            // Linha das assinaturas
            Paragraph linhas = new Paragraph()
                .AddTabStops(new TabStop(300, iText.Layout.Properties.TabAlignment.LEFT))
                .Add(new Text("_____________________________").SetFont(regular))
                .Add(new Tab())
                .Add(new Text("_____________________________").SetFont(regular));

            doc.Add(linhas);

            // Títulos em negrito
            Paragraph titulos = new Paragraph()
                .AddTabStops(new TabStop(300, iText.Layout.Properties.TabAlignment.LEFT))
                .Add(new Text("Assinatura do Cliente").SetFont(bold))
                .Add(new Tab())
                .Add(new Text("Responsável Técnico").SetFont(bold));

            doc.Add(titulos);
        }


        private void AdicionarTermoCiencia(Document doc)
        {
            doc.Add(new Paragraph("TERMOS DE SERVIÇO").SetFont(_bold).SetFontSize(14));

            // Texto ultra resumido mas com validade jurídica (CDC)
            string resumoLegal =
                "1. O orçamento é gratuito.\n\n2. Em casos de oxidação ou queda, o aparelho pode parar de funcionar " +
                "totalmente durante a tentativa de reparo devido à instabilidade do hardware. \n\n3. A garantia de 90 dias " +
                "refere-se apenas ao serviço executado, sendo anulada por mau uso, selo rompido ou contato com líquidos. " +
                "\n\n4. Aparelhos não retirados em 90 dias serão considerados abandonados (Art. 1.275 CC) e descartados ou " +
                "vendidos para cobrir custos de armazenamento.";

            doc.Add(new Paragraph(resumoLegal)
                .SetFontSize(11)
                .SetTextAlignment(TextAlignment.JUSTIFIED)
                .SetMultipliedLeading(0.9f)); // Diminui o espaçamento entre linhas
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
    }

}
