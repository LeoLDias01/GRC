using Data.Models;
using GRC.Properties;
using iText.IO.Font.Constants;
using iText.IO.Image;
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
using System.Drawing;
using System.Drawing.Printing;
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
                ofd.FileName = $"{DateTime.Today.ToString("dd-MM-yy")}_{_os.FirstOrDefault().Id}-{_os.FirstOrDefault().DadosCliente.Nome}.pdf";

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
           int idcliente = _os.FirstOrDefault().DadosCliente.Id;

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
                /*
                if (!viaCliente)
                {
                    AdicionarItens(doc, os);
                    AdicionarTotais(doc, os);
                    AdicionarTermo(doc);
                }
                else
                {*/
                    AdicionarResumoCliente(doc, os);/*
                }
               */
                AdicionarAssinaturas(doc);
                AdicionarTermoCiencia(doc);
                doc.Close();
            }

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
            doc.Add(separator);
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
            doc.Add(new Paragraph("\n"));
        }
        private void AdicionarDadosCliente(Document doc, OrdemServico os)
        {
            var line = new SolidLine();
            line.SetLineWidth(0.1f); // espessura da linha (quanto menor, mais fina)
            var separator = new LineSeparator(line);

            var table = new Table(1).UseAllAvailableWidth();

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont regular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            var p1 = new Paragraph()
                .Add(new Text("Cliente: ").SetFont(bold))
                .Add(new Text(os.DadosCliente.Nome).SetFont(regular));

            var p2 = new Paragraph()
                .Add(new Text("Descrição do Serviço: ").SetFont(bold))
                .Add(new Text(os.DescricaoSolucao).SetFont(regular));

            table.AddCell(new Cell()
                .Add(p1)
                //.Add(new Paragraph("\n"))                
               // .Add(p2)
                .SetBorder(Border.NO_BORDER));

            doc.Add(table);
            doc.Add(separator);
            //doc.Add(new Paragraph("\n"));
            //doc.Add(separator);
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
            

            doc.Add(new Paragraph(
                "O cliente autoriza a execução dos serviços descritos acima. " +
                "A loja não se responsabiliza por dados não informados, peças não aprovadas ou serviços adicionais não autorizados."
            ).SetFontSize(9));
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
        PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
        PdfFont regular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

        // Espaço antes (se vier após outro conteúdo)
        doc.Add(new Paragraph("\n"));

        // TÍTULO
        doc.Add(new Paragraph("TERMOS E CONDIÇÕES")
            .SetFont(bold)
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(12));

        doc.Add(new Paragraph("\n"));

        // 1. ORÇAMENTO
        doc.Add(new Paragraph()
            .Add(new Text("1. ORÇAMENTO\n").SetFont(bold))
            .Add(new Text(
                "O orçamento é realizado sem custo e não implica obrigação de reparo ou garantia de êxito, " +
                "tratando-se de avaliação técnica inicial."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 2. TENTATIVA DE REPARO
        doc.Add(new Paragraph()
            .Add(new Text("2. TENTATIVA DE REPARO\n").SetFont(bold))
            .Add(new Text(
                "Em serviços de reparo de placa, poderá haver tentativa de reparo sem garantia de sucesso, " +
                "ainda que sejam aplicadas técnicas adequadas, em razão da complexidade e das condições do equipamento."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 3. GARANTIA
        doc.Add(new Paragraph()
            .Add(new Text("3. GARANTIA\n").SetFont(bold))
            .Add(new Text(
                "A garantia cobre exclusivamente o serviço executado e/ou a peça substituída, conforme descrito " +
                "na ordem de serviço no momento da finalização do atendimento."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 4. O QUE A GARANTIA NÃO COBRE
        doc.Add(new Paragraph()
            .Add(new Text("4. O QUE A GARANTIA NÃO COBRE\n").SetFont(bold))
            .Add(new Text("A garantia não cobre, em nenhuma hipótese:\n").SetFont(regular))
            .Add(new Text(
                "- defeitos em partes ou setores do equipamento não relacionados ao serviço realizado;\n" +
                "- falhas decorrentes de mau uso, quedas, impactos, oxidação, umidade ou líquidos;\n" +
                "- problemas causados por intervenção de terceiros após a realização do serviço."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 5. EQUIPAMENTOS JÁ MANIPULADOS OU DANIFICADOS
        doc.Add(new Paragraph()
            .Add(new Text("5. EQUIPAMENTOS JÁ MANIPULADOS OU DANIFICADOS\n").SetFont(bold))
            .Add(new Text(
                "A empresa recebe equipamentos já abertos, reparados por terceiros, com sinais de oxidação, " +
                "umidade ou inoperantes. Nesses casos, a garantia, quando aplicável, restringe-se apenas ao setor reparado."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 6. LIMITAÇÃO DE RESPONSABILIDADE
        doc.Add(new Paragraph()
            .Add(new Text("6. LIMITAÇÃO DE RESPONSABILIDADE\n").SetFont(bold))
            .Add(new Text(
                "A R&F LabTech não se responsabiliza por defeitos posteriores que não possuam relação direta " +
                "com o serviço executado, ainda que ocorram durante o período de garantia."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 7. PRAZO PARA RETIRADA E DIÁRIA
        doc.Add(new Paragraph()
            .Add(new Text("7. PRAZO PARA RETIRADA E DIÁRIA\n").SetFont(bold))
            .Add(new Text(
                "Após a comunicação de conclusão do serviço ou liberação do equipamento, o cliente dispõe de " +
                "20 (vinte) dias corridos para retirada sem custo adicional. Após esse prazo, será cobrada diária " +
                "de armazenamento no valor de R$ 3,00 (três reais) por dia, até a retirada do equipamento."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 8. ABANDONO DE EQUIPAMENTO
        doc.Add(new Paragraph()
            .Add(new Text("8. ABANDONO DE EQUIPAMENTO\n").SetFont(bold))
            .Add(new Text(
                "Equipamentos não retirados no prazo de 90 (noventa) dias, contados a partir da comunicação ao cliente, " +
                "serão considerados abandonados, podendo ser destinados à venda ou descarte como forma de compensação " +
                "dos custos de armazenamento, espaço físico e serviços prestados."
            ).SetFont(regular)));

        doc.Add(new Paragraph("\n"));

        // 9. CIÊNCIA E ACEITE
        doc.Add(new Paragraph()
            .Add(new Text("9. CIÊNCIA E ACEITE\n").SetFont(bold))
            .Add(new Text(
                "Ao autorizar o serviço, o cliente declara estar ciente e de acordo com todos os termos acima."
            ).SetFont(regular)));
    }


    private void AdicionarResumoCliente(Document doc, OrdemServico os)
        {
            decimal total = os.ItensOrdemServico.Sum(i => i.Subtotal);

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont regular = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            var line = new SolidLine();
            line.SetLineWidth(0.1f);
            var separator = new LineSeparator(line);

            doc.Add(new Paragraph()
                .Add(new Text("Descrição do Serviço: ").SetFont(bold))
                .Add(new Text(os.DescricaoSolucao).SetFont(regular)));

            doc.Add(new Paragraph()
                .Add(new Text("Data de Entrada: ").SetFont(bold))
                .Add(new Text(os.DataEntrada).SetFont(regular)));

            doc.Add(new Paragraph()
                .Add(new Text("Previsão de Entrega: ").SetFont(bold))
                .Add(new Text(os.FimPrevisto ?? " ").SetFont(regular)));

            doc.Add(new Paragraph("\n"));
            doc.Add(separator);

            doc.Add(new Paragraph()
                .Add(new Text("Valor Total: ").SetFont(bold))
                .Add(new Text(total.ToString("C2")).SetFont(regular)));

            doc.Add(new Paragraph("\n"));
        }

    }

}
