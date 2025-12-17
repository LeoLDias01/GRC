using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Session;
using Domain.Repository;

namespace Business.Services
{
    public class ServiceLogin
    {
        DatabaseLogin _database = new DatabaseLogin();

        /// <summary>
        /// Verifica login, inicia sessão e retorna true se usuário existe
        /// </summary>
        public bool VerificaLogin(string usuario, string senha)
        {
            try
            {
                // Retorna lista de usuários do banco
                var usuarios = _database.VerificaLogin(usuario, senha);

                if (usuarios != null && usuarios.Count > 0)
                {
                    var login = usuarios.First();

                    
                    Sessao.IniciarSessao(login.Id, login.Nome, login.Usuario);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
