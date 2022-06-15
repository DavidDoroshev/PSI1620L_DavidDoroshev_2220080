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

            ligarDB.Close();

            ligarDB.Open();

            nome_trabalhador.Text = Iniciar_Sessao.trabalhador;
            nome_trabalhador.Enabled = false;

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            command.CommandText = "select * from codigo_postal";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                codigo_alterar.Items.Add(reader["codigo_postal"].ToString());
            }

            ligarDB.Close();

            textconselho.Enabled = false;
            textdistrito.Enabled = false;


        }

        private void apagar_trabalhador_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

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
            ligarDB.Close();

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

        private void salvar_codigo_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();

            if (codigo_alterar.Text == "")
            {
                MessageBox.Show("Tem de selecionar algum código postal");
                return;
            }
            string query = "UPDATE trabalhadores SET codigo_postal_trabalhador = '" + codigo_alterar.Text + "' WHERE nome = '" + Iniciar_Sessao.trabalhador + "' ";
            SqlCommand cmd = new SqlCommand(query, ligarDB);


            cmd.ExecuteReader();

            MessageBox.Show("CP alterado");

            ligarDB.Close();
        }

        private void codigo_alterar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;

            ligarDB.Close();

            ligarDB.Open();

            command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo";

            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_alterar.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string concelho = reader["conselho"].ToString();
            string distrito = reader["distrito"].ToString();

            textconselho.Text = concelho;
            textdistrito.Text = distrito;

            ligarDB.Close();
        }
    }
}

