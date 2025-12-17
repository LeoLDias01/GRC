using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Whatsapp { get; set; }
        public string Observacoes { get; set; }
    }
}
