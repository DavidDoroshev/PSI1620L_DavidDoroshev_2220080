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
    }
}
