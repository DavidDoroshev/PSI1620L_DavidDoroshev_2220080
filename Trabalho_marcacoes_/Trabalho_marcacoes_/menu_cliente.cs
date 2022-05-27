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
    public partial class menu_cliente : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public menu_cliente()
        {
            InitializeComponent();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {

        }

        private void marcar_Click(object sender, EventArgs e)
        {
            
        }

        private void textonome_Click(object sender, EventArgs e)
        {

        }
        private void marcar_estetica_Click(object sender, EventArgs e)
        {
            marcar_estetica ir = new marcar_estetica();
            ir.Show();
            this.Close();
        }

        private void ir_medico_Click(object sender, EventArgs e)
        {
            marcar_medico ir = new marcar_medico();
            ir.Show();
            this.Close();
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            current_user.Text = Iniciar_Sessao.utilizador;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
