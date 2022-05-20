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
    public partial class trabalhador_criar : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);

        public trabalhador_criar()
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
            inicial voltar = new inicial();
            voltar.Show();
            this.Hide();
        }
        private void trabalhador_criar_Load(object sender, EventArgs e)
        {
            
        }

        private void profissao_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            ligarDB.Close();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;

            

            try
            {
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
        }

        private void guardar_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;

            ligarDB.Open();
            

            command.CommandText = "INSERT INTO trabalhadores(nome, password, codigo_postal_trabalhador, especialidade_tabela_trabalhador) VALUES(@nome, @password, @codigo_postal, @especialidade)";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_trabalhador.Text;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_trabalhador.Text;
            command.Parameters.Add("@codigo_postal", System.Data.SqlDbType.VarChar).Value = codigo_postal_trabalhador.SelectedItem.ToString();
            command.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = especialidade_select.SelectedItem.ToString();

            command.ExecuteNonQuery();

            ligarDB.Close();

            MessageBox.Show("Trabalhador adicionado com sucesso");

            this.Close();
        }

        private void codigo_postal_trabalhador_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            ligarDB.Open();

           

            command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo";

            command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_postal_trabalhador.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string concelho = reader["conselho"].ToString();
            string distrito = reader["distrito"].ToString();

            textconselho.Text = concelho;
            textdistrito.Text = distrito;
        }
    }
}
