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
using System.Text.RegularExpressions;
namespace Trabalho_marcacoes_
{
    public partial class perfil_cliente : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public perfil_cliente()
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

            var input = pass_alterar.Text;

            Regex valid = new Regex("^(?!.*[!@#$%^&*()_+={};:<>|./?,-])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8}$");

            if (input == "")
            {
                MessageBox.Show("Tem de ter passs");
                return;
            }
            else if (!valid.IsMatch(input))
            {
                MessageBox.Show("Tem alguma coisa de errado");
                return;
            }

            string query = "UPDATE cliente SET password = '" + pass_alterar.Text + "' WHERE nome = '" + Iniciar_Sessao.utilizador + "' ";
            SqlCommand cmd = new SqlCommand(query, ligarDB);

                
            cmd.ExecuteReader();

            MessageBox.Show("Pass alterada");

            ligarDB.Close();
        }

        private void apagar_cliente_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            string query2 = "DELETE marcacoes_cliente FROM marcacoes_cliente RIGHT JOIN cliente on marcacoes_cliente.nome_cliente_id = cliente.id WHERE cliente.nome = '" + Iniciar_Sessao.utilizador + "'";
            SqlCommand cm = new SqlCommand(query2, ligarDB);

            
            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            reader.Close();


            string query = "  DELETE FROM cliente WHERE nome = '" + Iniciar_Sessao.utilizador + "'";
            SqlCommand cmd = new SqlCommand(query, ligarDB);


            cmd.ExecuteReader();

            ligarDB.Close();

            MessageBox.Show("Utilizador apagado !!!");

            menu_inicial ir = new menu_inicial();
            this.Hide();
            ir.Show();

        }
    }
}
