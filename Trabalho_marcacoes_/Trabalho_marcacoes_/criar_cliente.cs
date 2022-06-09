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
    public partial class criar_conta : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);


        public criar_conta()
        {
           
                ligarDB.Open();

                InitializeComponent();
                SqlCommand command = new SqlCommand();
                command.Connection = ligarDB;
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

        public async void  guardar_cliente_Click( object sender, EventArgs e)
        {

            ligarDB.Close();

            ligarDB.Open();

            var pass_veri = password_guardar.Text;

            var nome_veri = nome_guardar.Text;           

            Regex valid_pass = new Regex("^(?!.*[!@#$%^&*()_+={};:<>|./?,-])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{3,15}$");

            Regex valid_nome = new Regex("^(?!.*[!@#$%^&*()_+={};:<>|./?,-])[A-Z]{1}[a-zA-Z]{2,24}$");

            if (pass_veri == "" || nome_veri == "" )
            {
                MessageBox.Show("Tem de ter algo escrito");
                return;
            }
            else if (!valid_pass.IsMatch(pass_veri) || !valid_nome.IsMatch(nome_veri))
            {
                MessageBox.Show("Tem alguma coisa de errado");
                return;
            }

            SqlCommand commando = new SqlCommand();


            string query = "SELECT * FROM cliente WHERE nome = '" + nome_guardar.Text + "'";
            commando = new SqlCommand(query, ligarDB);
            SqlDataReader reader = await commando.ExecuteReaderAsync();
            await reader.ReadAsync();
            if (reader.HasRows)
            {


                MessageBox.Show("Nome ja se encontra registado");
                nome_guardar.Text = "";
                nome_guardar.Select();
                reader.Close();
                ligarDB.Close();
                return;

            }
            else
            {

                reader.Close();
                commando.CommandText = "INSERT INTO cliente(nome, password, codigo_postal_cliente) VALUES(@nome, @password, @codigo)";
                commando.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_guardar.Text;
                commando.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_guardar.Text;
                commando.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_guardar.SelectedItem.ToString();
                await commando.ExecuteNonQueryAsync();

                MessageBox.Show("Cliente adicionado com sucesso!!!");

                menu_inicial voltar = new menu_inicial();
                voltar.Show();
                this.Close();

                ligarDB.Close();

            }

        }

        private void voltar_iniciar_Click(object sender, EventArgs e)
        {
            menu_inicial voltar = new menu_inicial();
            voltar.Show();
            this.Hide();
        }
       
        private void codigo_guardar_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;


            ligarDB.Close();
            ligarDB.Open();

            command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo"; 

            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_guardar.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string concelho = reader["conselho"].ToString();
            string distrito = reader["distrito"].ToString();

            textconselho.Text = concelho;
            textdistrito.Text = distrito;

            ligarDB.Close();
        }

        private void textconselho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdistrito_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
