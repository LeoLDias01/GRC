using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRC.Telas
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            LoadTimer.Interval = 4000;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "Versão: " + System.Windows.Forms.Application.ProductVersion;
            DirectorySaveGameCreate();
            LoadTimer.Start();
        }
        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadTimer.Stop();
            if (VerificaBanco())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Banco de dados foi perdido ou corrompido, chame o suporte", "ERRO GRAVISSIMO!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        private void DirectorySaveGameCreate()
        {
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\GRC-Arquivos"))
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\GRC-Arquivoss");
        }
        private bool VerificaBanco()
        {
            string diretorioSistema = Path.Combine("C:\\GRC\\Databases", "rf_db.db");
            if (File.Exists(diretorioSistema))
                return true;
            else return false;
        }

        
    }
}
