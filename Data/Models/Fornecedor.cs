using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string IE { get; set; }
        public string Cnpj { get; set; }
        public string Observacoes { get; set; }

        public Endereco Endereco { get; set; } = new Endereco();
        public Email Email { get; set; } = new Email();
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();
    }
}
