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
    public partial class menu_trabalhador : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public menu_trabalhador()
        {
            InitializeComponent();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;

            ligarDB.Open();

            //command.CommandText = "SELECT nome FROM trabalhadores";

            command.CommandText = "UPDATE trabalhadores SET nome = '"+ trabalhador_atual.Text + "' " ;
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = trabalhador_atual.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string nome = reader["nome"].ToString();

            trabalhador_atual.Text = nome;
            ligarDB.Close();
        }

        
    }
}
