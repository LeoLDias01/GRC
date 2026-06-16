using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ItemCard : Item
    {
        public int IdCard { get; set; } // IDGRC_ITEM_OS - Vincula o Item a OS
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => ValorUnitario * Quantidade;

        // CAMPOS DE APOIO (snapshot)
        public int QuantidadeMaxima { get; set; }
    }
}
