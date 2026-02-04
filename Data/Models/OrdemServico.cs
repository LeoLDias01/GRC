using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Descricao { get; set; }
        public int TipoServico { get; set; }
        public int Status { get; set; }
        public int StatusAntigo { get; set; }
        public string DescricaoStatus { get; set; }
        public string DescricaoTipo { get; set; }
        public string Garantia { get; set; }
        public string DataEntrada { get; set; }
        public string FimPrevisto { get; set; }
        public string FimReal { get; set; }
        public string InicioGarantia { get; set; }
        public string FimGarantia { get; set; }
        public string MaoObra { get; set; }
        public string Acrescimo { get; set; }
        public string Desconto { get; set; }
        public string Observacoes { get; set; }
        public bool Favorito { get; set; }
        public bool Ativo { get; set; }

        public List<ItemCard> ItensOrdemServico { get; set; } = new List<ItemCard>();
    }
}
