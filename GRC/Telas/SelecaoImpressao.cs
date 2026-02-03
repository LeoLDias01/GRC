using Data.Models;
using GRC.Properties;
using iText.IO.Image;
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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iText.Layout.Element.Image;

namespace GRC.Telas
{
    public partial class SelecaoImpressao : Form
    {
        List<OrdemServico> _os = new List<OrdemServico>();
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione onde salvar o PDF da Ordem de Serviço";

                // Sugere o nome do arquivo
                ofd.FileName = $"{DateTime.Today.ToString("dd-MM-yy")}_{_os.FirstOrDefault().Id}-{_os.FirstOrDefault().NomeCliente}.pdf";

                // Filtro apenas PDF
                ofd.Filter = "Arquivo PDF (*.pdf)|*.pdf";

                // Diretório inicial
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Importante: permite escolher caminho + nome
                ofd.CheckFileExists = false;
                ofd.CheckPathExists = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoCompleto = ofd.FileName;

                    if (chkCliente.Checked)
                        GerarPdfOrdemServico(caminhoCompleto, true);
                    if (chkLoja.Checked)
                        GerarPdfOrdemServico(caminhoCompleto, false);
                }
            }
        }

        private void SelecaoImpressao_Load(object sender, EventArgs e)
        {
            
        }
        public void GerarPdfOrdemServico(string caminhoArquivo, bool viaCliente)
        {
            DadosLoja dadosLoja = new DadosLoja();
            var writer = new PdfWriter(caminhoArquivo);
            var pdf = new PdfDocument(writer);
            var doc = new Document(pdf, PageSize.A4);

            foreach (var os in _os)
            {
               

                doc.SetMargins(20, 20, 20, 20);

                AdicionarCabecalho(doc, dadosLoja);
                AdicionarTitulo(doc, os);
                AdicionarDadosCliente(doc, os);

                if (!viaCliente)
                {
                    AdicionarItens(doc, os);
                    AdicionarTotais(doc, os);
                    AdicionarTermo(doc);
                }
                else
                {
                    AdicionarResumoCliente(doc, os);
                }

                AdicionarAssinaturas(doc);
                doc.Close();
            }

        }


        private void AdicionarCabecalho(Document doc, DadosLoja loja)
        {
            var table = new Table(new float[] { 1.5f, 4 })
                .UseAllAvailableWidth();

            // LOGO (Resources)
            var logoBytes = BitmapToBytes(Properties.Resources.RF_LabTech_Logo);
            var logo = new Image(ImageDataFactory.Create(logoBytes))
                .SetWidth(90);

            table.AddCell(new Cell()
                .Add(logo)
                .SetBorder(Border.NO_BORDER));

            table.AddCell(new Cell()
                .Add(new Paragraph(loja.Nome))
                .Add(new Paragraph($"CNPJ: {loja.Cnpj}"))
                .Add(new Paragraph(loja.Endereco))
                .Add(new Paragraph($"Telefone: {loja.Telefone}"))
                .SetBorder(Border.NO_BORDER));

            doc.Add(table);
            doc.Add(new Paragraph("\n"));
        }
        private byte[] BitmapToBytes(Bitmap bitmap)
        {
            var ms = new MemoryStream();
            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }
        private void AdicionarTitulo(Document doc, OrdemServico os)
        {
            doc.Add(new Paragraph("ORDEM DE SERVIÇO DE MANUTENÇÃO")
                .SetFontSize(16)
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Add(new Paragraph($"OS Nº: {os.Id}")
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Add(new Paragraph($"Data de Entrada: {os.DataEntrada}")
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Add(new LineSeparator(new SolidLine()));
        }
        private void AdicionarDadosCliente(Document doc, OrdemServico os)
        {
            var table = new Table(2).UseAllAvailableWidth();

            table.AddCell("Cliente:");
            table.AddCell(os.NomeCliente);

            table.AddCell("Descrição do Serviço:");
            table.AddCell(os.Descricao);

            doc.Add(table);
            doc.Add(new Paragraph("\n"));
        }
        private void AdicionarItens(Document doc, OrdemServico os)
        {
            var table = new Table(new float[] { 1, 4, 2, 2 })
                .UseAllAvailableWidth();

            table.AddHeaderCell("Qtd");
            table.AddHeaderCell("Peça / Item");
            table.AddHeaderCell("Valor Unit.");
            table.AddHeaderCell("Subtotal");

            foreach (var item in os.ItensOrdemServico)
            {
                table.AddCell(item.Quantidade.ToString());
                table.AddCell(item.Descricao);
                table.AddCell(item.ValorUnitario.ToString("C2"));
                table.AddCell(item.Subtotal.ToString("C2"));
            }

            doc.Add(table);
        }
        private void AdicionarTotais(Document doc, OrdemServico os)
        {
            decimal total = os.ItensOrdemServico.Sum(i => i.Subtotal);

            doc.Add(new Paragraph($"\nTotal de Peças: {total:C2}"));
        }
        private void AdicionarTermo(Document doc)
        {
            doc.Add(new Paragraph("\nTermos e Condições:"));

            doc.Add(new Paragraph(
                "O cliente autoriza a execução dos serviços descritos acima. " +
                "A loja não se responsabiliza por dados não informados, peças não aprovadas ou serviços adicionais não autorizados."
            ).SetFontSize(9));
        }
        private void AdicionarAssinaturas(Document doc)
        {
            var table = new Table(2).UseAllAvailableWidth();

            table.AddCell("\n\n_____________________________\nAssinatura do Cliente");
            table.AddCell("\n\n_____________________________\nResponsável Técnico");

            doc.Add(table);
        }
        private void AdicionarResumoCliente(Document doc, OrdemServico os)
        {
            decimal total = os.ItensOrdemServico.Sum(i => i.Subtotal);


            var table = new Table(2).UseAllAvailableWidth();

            table.AddCell("Descrição do Reparo:");
            table.AddCell(os.Descricao);

            table.AddCell("Data de Entrada:");
            table.AddCell(os.DataEntrada);

            table.AddCell("Previsão de Entrega:");
            table.AddCell(os.FimPrevisto ?? "-");

            table.AddCell("Valor Total:");
            table.AddCell(total.ToString("C2"));

            doc.Add(table);
        }

    }

}
