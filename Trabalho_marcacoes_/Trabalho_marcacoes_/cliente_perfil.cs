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
    public partial class cliente_perfil : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public cliente_perfil()
        {
            InitializeComponent();
     
            nome_utilizador.Text = Iniciar_Sessao.utilizador;
            nome_utilizador.Enabled = false;

            

        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            menu_cliente ir = new menu_cliente();
            this.Hide();
            ir.Show();
        }

        private void but_salvar_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            try
            {
                string query = "UPDATE cliente SET password = '" + pass_alterar + "' WHERE nome = '" + Iniciar_Sessao.utilizador + "' ";
                SqlCommand cmd = new SqlCommand(query, ligarDB);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pass alterada");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ligarDB.Close();
        }
    }
}
