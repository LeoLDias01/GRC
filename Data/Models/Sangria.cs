using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Sangria
    {
        public int Id { get; set; }
        public int CaixaId { get; set; } // FK para o caixa do dia
        public DateTime DataHora { get; set; }
        public string Valor { get; set; }
        public string Observacao { get; set; } // Ex: "Compra de conectores de carga"
        public string Usuario { get; set; }    // Quem realizou a retirada
    }
}
