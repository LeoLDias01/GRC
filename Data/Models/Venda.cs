using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdCaixa { get; set; } // Chave Estrangeira
        public int IdCliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public List<OrdemServico> Os { get; set; } = new List<OrdemServico>();
        public List<Item> Itens { get; set; } = new List<Item>();
        public List<Finalizador> Finalizadores { get; set; } = new List<Finalizador>();
    }
}
