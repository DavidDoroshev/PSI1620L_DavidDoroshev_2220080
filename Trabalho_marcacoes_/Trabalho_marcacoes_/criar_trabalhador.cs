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
    public partial class criar_trabalhador : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);

        public criar_trabalhador()
        {
            
                ligarDB.Open();

                InitializeComponent();
                SqlCommand command = new SqlCommand();
                command.Connection = ligarDB;
                command.CommandText = "select distinct * from profissao_tabela";
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                profissao_select.Items.Add(reader["profissao"].ToString());
            }
            ligarDB.Close();
            reader.Close();

            
                ligarDB.Close();
                ligarDB.Open();
                command.CommandText = "select * from codigo_postal";
                
                
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    codigo_postal_trabalhador.Items.Add(reader["codigo_postal"].ToString());
                }
                ligarDB.Close();
                reader.Close();


                textconselho.Enabled = false;
                textdistrito.Enabled = false;

                
                ligarDB.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_inicial voltar = new menu_inicial();
            voltar.Show();
            this.Hide();
        }


        private void profissao_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ligarDB.Close();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;



                especialidade_select.Items.Clear();
                especialidade_select.Text = "";

                ligarDB.Open();
                command.CommandText = "SELECT especialidade_tabela.especialidade FROM profissao_tabela INNER JOIN especialidade_tabela on especialidade_tabela.profissao  = profissao_tabela.id_profissao WHERE profissao_tabela.profissao = @profissao";
               

                command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar).Value = profissao_select.Text;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    especialidade_select.Items.Add(reader.GetString(0));
                }

                ligarDB.Close();
            
            
        }

        public async void guardar_button_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();


            var pass_veri = password_trabalhador.Text;

            var nome_veri = nome_trabalhador.Text;


            Regex valid_pass = new Regex("^(?!.*[!@#$%^&*()_+=\\[/{}];:<>|./?,-])(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{9,15}$");

            Regex valid_nome = new Regex("^(?!.*[!@#$%^&*()_+={};:<>|./?,-])[A-Z]{1}[a-zA-Z]{2,}$");

            if (pass_veri == "" || nome_veri == "")
            {
                MessageBox.Show("Tem de ter passs");
                return;
            }
            else if (!valid_pass.IsMatch(pass_veri) || !valid_nome.IsMatch(nome_veri))
            {
                MessageBox.Show("Tem alguma coisa de errado");
                return;
            }

            SqlCommand commando = new SqlCommand();

            string query = "SELECT * FROM trabalhadores WHERE nome = '" + nome_trabalhador.Text + "'";
            commando = new SqlCommand(query, ligarDB);
            SqlDataReader reader = await commando.ExecuteReaderAsync();
            await reader.ReadAsync();
            if (reader.HasRows)
            {

            }
            else
            {
                commando.CommandText = "INSERT INTO trabalhadores(nome, password, codigo_postal_trabalhador, especialidade_tabela_trabalhador) VALUES(@nome, @password, @codigo_postal, @especialidade)";
                commando.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_trabalhador.Text;
                commando.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_trabalhador.Text;
                commando.Parameters.Add("@codigo_postal", System.Data.SqlDbType.VarChar).Value = codigo_postal_trabalhador.SelectedItem.ToString();
                commando.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = especialidade_select.SelectedItem.ToString();

                await commando.ExecuteNonQueryAsync();

                ligarDB.Close();

                MessageBox.Show("Trabalhador adicionado com sucesso!!!");

                menu_inicial voltar = new menu_inicial();
                voltar.Show();
                this.Hide();
            }
        }

        private void codigo_postal_trabalhador_SelectedIndexChanged(object sender, EventArgs e) 
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            ligarDB.Close();
            ligarDB.Open();

           

            command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo";

            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_postal_trabalhador.Text;

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
