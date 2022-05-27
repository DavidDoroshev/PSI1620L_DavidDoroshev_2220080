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
    public partial class menu_trabalhador : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public menu_trabalhador()
        {
            InitializeComponent();            
        }

        private void perfil_trabalhador_Click(object sender, EventArgs e)
        {
            trabalhador_atual.Text = Iniciar_Sessao.trabalhador;
        }
    }
}
