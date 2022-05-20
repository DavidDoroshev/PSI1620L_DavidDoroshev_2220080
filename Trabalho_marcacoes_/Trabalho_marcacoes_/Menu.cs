using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Trabalho_marcacoes_
{
    public partial class Menu : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public Menu()
        {
            InitializeComponent();

        }

        private void Perfil_Click(object sender, EventArgs e)
        {

        }

        private void marcar_Click(object sender, EventArgs e)
        {
            marcar_fazer ir = new marcar_fazer();
            ir.Show();
            this.Close();
        }

        private void textonome_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Marcações_Click(object sender, EventArgs e)
        {
            
        }
    }
}
