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
            ligarDB.Close();

            ligarDB.Open();

            nome_utilizador.Text = Iniciar_Sessao.utilizador;
            nome_utilizador.Enabled = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ligarDB;
            cmd.CommandText = "SELECT * FROM cliente WHERE nome = @nome ";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = Iniciar_Sessao.utilizador;
            SqlDataReader read = cmd.ExecuteReader();

            while(read.Read())
            {

                pass_atual.Text = read["password"].ToString();
                pass_atual.Enabled = false;

                cp_mostrar.Text = read["codigo_postal_cliente"].ToString();
                cp_mostrar.Enabled = false;
            }

            read.Close();

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

        private void Voltar_Click(object sender, EventArgs e)
        {
            menu_cliente ir = new menu_cliente();
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

            string query = "UPDATE cliente SET password = '" + pass_alterar.Text + "' WHERE nome = '" + Iniciar_Sessao.utilizador + "' ";
            SqlCommand cmd = new SqlCommand(query, ligarDB);

            cmd.ExecuteReader();

            cmd.CommandText = "SELECT * FROM cliente WHERE nome = @nome ";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = Iniciar_Sessao.utilizador;
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                pass_atual.Text = read["password"].ToString();
                pass_atual.Enabled = false;
            }


            MessageBox.Show("Pass alterada");

            ligarDB.Close();
        }

        private void apagar_cliente_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

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

        private void salvar_codigo_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();
            
            if(codigo_alterar.Text == "")
            {
                MessageBox.Show("Tem de selecionar algum Código Postal");
                return;
            }

            string query = "UPDATE cliente SET codigo_postal_cliente = '" + codigo_alterar.Text + "' WHERE nome = '" + Iniciar_Sessao.utilizador + "' ";
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
