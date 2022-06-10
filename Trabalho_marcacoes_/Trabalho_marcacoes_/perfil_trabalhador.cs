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
    public partial class perfil_trabalhador : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public perfil_trabalhador()
        {
            InitializeComponent();

            nome_trabalhador.Text = Iniciar_Sessao.trabalhador;
            nome_trabalhador.Enabled = false;


        }

        private void apagar_trabalhador_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            string query2 = "DELETE marcacoes_cliente  FROM marcacoes_cliente INNER JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id where trabalhadores.nome = '"+ Iniciar_Sessao.trabalhador +"' ";
            SqlCommand cm = new SqlCommand(query2, ligarDB);


            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            reader.Close();


            string query = "  DELETE FROM trabalhadores WHERE nome = '" + Iniciar_Sessao.trabalhador + "'";
            SqlCommand cmd = new SqlCommand(query, ligarDB);


            cmd.ExecuteReader();

            ligarDB.Close();

            MessageBox.Show("Trabalhador apagado !!!");

            menu_inicial ir = new menu_inicial();
            this.Hide();
            ir.Show();
        }

        private void but_salvar_Click(object sender, EventArgs e)
        {
            ligarDB.Open();

            var input = pass_alterar.Text;

            Regex valid = new Regex("^(?!.*[!@#$%^&*()_+={};:<>|./?,-])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{3,15}$");

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

            string query = "UPDATE trabalhadores SET password = '" + pass_alterar.Text + "' WHERE nome = '" + Iniciar_Sessao.trabalhador + "' ";
            SqlCommand cmd = new SqlCommand(query, ligarDB);


            cmd.ExecuteReader();

            MessageBox.Show("Pass alterada");

            ligarDB.Close();
        }
        private void Voltar_Click_1(object sender, EventArgs e)
        {
            menu_trabalhador ir = new menu_trabalhador();
            this.Hide();
            ir.Show();
        }
    }
}
