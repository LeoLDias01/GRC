using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string CodBarras { get; set; }
        public string Garantia { get; set; }
        public string Validade { get; set; }
        public int UnidadeMedida { get; set; }
        public int QuatidadeMinima { get; set; }
        public int Quatidade { get; set; }
        public string CustoUnitario { get; set; }
        public int Categoria { get; set; }
        public int Fabricante { get; set; }
        public int Fornecedor { get; set; }
        public string Observacoes { get; set; }
        public bool Favorito { get; set; }
        public string FotoItem { get; set; }
        public bool ItemVenda {  get; set; }
        public string DescricaoVenda { get; set; }
        public string VendaUnitario { get; set; }
        public bool Ativo {  get; set; }

        public List<Composicao> ComposicaoItem { get; set; } = new List<Composicao>();


        // Apenas para Busca Simples
        public string DescricaoCategoria { get; set; }
        public string DescricaoFabricante { get; set; }
        public string DescricaoFornecedor { get; set; }
    }
}
