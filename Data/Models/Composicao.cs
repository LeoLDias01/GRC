using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Composicao
    {
        public long? Id { get; set; }   // ID da tabela GRC_COMPOSICAO
        public long IdItemComposicao { get; set; } // ID do item que compõe
        public string Descricao { get; set; }
        public string Preco { get; set; }
    }
}
