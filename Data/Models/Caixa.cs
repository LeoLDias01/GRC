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
        public  int Usuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public bool Aberto { get; set; }
        public string SaldoAbertura { get; set; } // Valor que começou na gaveta
        public string SaldoFechamento { get; set; }   // Valor total ao fechar
        public string Observacoes { get; set; }
        public int PDV { get; set; }

        public decimal SaldoCaixa { get; set; }
      
        public List<Sangria> Sangrias { get; set; } = new List<Sangria>(); // Para retiradas
    }

}
