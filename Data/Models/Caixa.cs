using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Caixa
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public bool Situacao { get; set; }
        public string SaldoAbertura { get; set; } // Valor que começou na gaveta
        public string SaldoFechamento { get; set; }   // Valor total ao fechar
        public List<Sangria> Sangrias { get; set; } = new List<Sangria>(); // Para retiradas
    }

}
