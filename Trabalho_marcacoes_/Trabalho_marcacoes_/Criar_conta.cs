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
    public partial class criar_conta : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);


        public criar_conta()
        {
            try
            {
                ligarDB.Open();

                InitializeComponent();
                SqlCommand command = new SqlCommand();
                command.Connection = ligarDB;
                /* SqlDataReader commandReader = command.ExecuteReader();
                commandReader.Read(); */
                command.CommandText = "select * from codigo_postal";
                SqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    codigo_guardar.Items.Add(reader["codigo_postal"].ToString());
                }

                ligarDB.Close();

                textconselho.Enabled = false;
                textdistrito.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void guardar_cliente_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();
            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;

            command.CommandText = "INSERT INTO cliente(nome, password, codigo_postal_cliente) VALUES(@nome, @password, @codigo)";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_guardar.Text;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_guardar.Text;
            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_guardar.SelectedItem.ToString();

            command.ExecuteNonQuery();

            ligarDB.Close();

            MessageBox.Show("Utilizador adicionado com sucesso");

            this.Close();
            


        }

        private void voltar_iniciar_Click(object sender, EventArgs e)
        {
            inicial voltar = new inicial();
            voltar.Show();
            this.Hide();
        }

        private void codigo_guardar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;

            ligarDB.Open();

            command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo"; 

            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_guardar.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string concelho = reader["conselho"].ToString();
            string distrito = reader["distrito"].ToString();

            textconselho.Text = concelho;
            textdistrito.Text = distrito;
        }

        private void textconselho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdistrito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
