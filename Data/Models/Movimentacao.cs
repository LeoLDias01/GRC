using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int IdItem { get; set; }
        public string DescricaoItem { get; set; }
        public int IdTipoMovimentacao { get; set; }
        public string DescricaoTipoMovimentacao { get; set; }
        public string Motivo { get; set; }
        public int Quantidade { get; set; }
        public string CustoUnitario { get; set; }
        public string Observacoes { get; set; }
        public string DataMovimentacao { get; set; }
        public string DataReal { get; set; }
        public bool Bloqueada { get; set; }
        public bool Ativo { get; set; }
    }
}
