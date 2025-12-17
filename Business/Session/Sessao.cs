using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Session
{
    public class Sessao
    {
        public static int UsuarioId { get; private set; }
        public static string UsuarioNome { get; private set; }
        public static string Usuario {  get; private set; }

        public static void IniciarSessao(int id, string nome, string user)
        {
            UsuarioId = id;
            UsuarioNome = nome;
            Usuario = user;
        }

        public static void EncerrarSessao()
        {
            UsuarioId = 0;
            UsuarioNome = null;
            Usuario = null;
        }
    }
}
