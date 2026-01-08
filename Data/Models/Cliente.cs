using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Identidade { get; set; }
        public string Observacoes { get; set; }
        public int TipoPessoa { get; set; }
        public bool Ativo { get; set; }
        public Endereco Endereco { get; set; } = new Endereco();
        public Email Email { get; set; } = new Email();
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();
    }
}
