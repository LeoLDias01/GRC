using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ItemCard
    {
        public int IdItem { get; set; }
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public decimal Subtotal => ValorUnitario * Quantidade;
    }
}
