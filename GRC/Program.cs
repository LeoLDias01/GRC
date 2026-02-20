using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;
using GRC.Telas;
namespace GRC
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WorkFlow());
            Application.Run(new CadastroOS(1));
            //Application.Run(new CadastroMovimentacao());

        }
    }
}
