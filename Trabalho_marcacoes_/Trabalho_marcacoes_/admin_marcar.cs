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
    public partial class admin_marcar : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);
        public admin_marcar()
        {
            ligarDB.Open();

            InitializeComponent();
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            command.CommandText = "SELECT nome FROM cliente";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                cliente_mostrar.Items.Add(reader["nome"].ToString());
            }
            ligarDB.Close();
            reader.Close();

            ligarDB.Close();
            ligarDB.Open();
            command.CommandText = "select * from trabalhadores";


            reader = command.ExecuteReader();
            while (reader.Read())
            {

                trabalhador_nome.Items.Add(reader["nome"].ToString());
            }
            ligarDB.Close();
            reader.Close();


            especialidade.Enabled = false;


            ligarDB.Close();
        }

        private void cliente_mostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            ligarDB.Open();



            command.CommandText = "SELECT nome FROM cliente WHERE nome = @nome";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = cliente_mostrar.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            ligarDB.Close();

        }

        private void especialidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void trabalhador_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            ligarDB.Open();

            command.CommandText = "SELECT trabalhadores.nome, especialidade_tabela.especialidade FROM trabalhadores INNER JOIN especialidade_tabela ON trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade WHERE trabalhadores.nome = @nome";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = trabalhador_nome.SelectedItem.ToString();

            SqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Read();

                string especialidad = reader["especialidade"].ToString();

                especialidade.Text = especialidad;
                ligarDB.Close();
            }
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string da = DateTime.Now.ToShortDateString();

            Regex ver = new Regex("^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");

            var veri = hora_guardar.Text;

            if (!ver.IsMatch(veri))
            {
                MessageBox.Show("Não pode por essas horas");
                return;
            }
            try
            {
                SqlCommand command = new SqlCommand();

                command.Connection = ligarDB;
                ligarDB.Close();
                ligarDB.Open();

                string query = "INSERT INTO marcacoes_cliente(dia_marcacao, hora, nome_cliente_id, nome_trabalhador_id, especialidade_marcacao ) VALUES(@dia, @hora ,@id, @nome_trabalhador, @especialidade)";
                string query2 = "SELECT id FROM cliente WHERE nome = @id";
                string query3 = "SELECT id FROM trabalhadores WHERE nome = @nome";

                SqlCommand cmd = new SqlCommand(query, ligarDB);
                SqlCommand ns = new SqlCommand(query2, ligarDB);
                SqlCommand command2 = new SqlCommand(query3, ligarDB);

                ns.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente_mostrar.SelectedItem.ToString();
                command2.Parameters.Add("@nome", SqlDbType.VarChar).Value = trabalhador_nome.SelectedItem.ToString();

                SqlDataReader reader = ns.ExecuteReader();
                reader.Read();

                int id = Convert.ToInt32(reader["id"]);
                reader.Close();

                reader = command2.ExecuteReader();
                reader.Read();

                int idtrabalhador = Convert.ToInt32(reader["id"]);
                reader.Close();

                cmd.Parameters.Add("@dia", System.Data.SqlDbType.Date).Value = dia_guardar.Text;
                cmd.Parameters.Add("@hora", System.Data.SqlDbType.Time).Value = hora_guardar.Text;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nome_trabalhador", System.Data.SqlDbType.VarChar).Value = idtrabalhador;
                cmd.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = especialidade.Text;

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ligarDB.Close();


            MessageBox.Show("Marcação feita com sucesso");

            admin principal = new admin();
            this.Hide();
            principal.Show();
        }
    }
}
