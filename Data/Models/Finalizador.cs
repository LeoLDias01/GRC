using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Finalizador
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Categoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public int IdImagem { get; set; }
        public bool Parcelamento { get; set; }
        public int Parcelas { get; set; }
        public bool Ativo { get; set; }
    }
}
