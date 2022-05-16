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
    public partial class Menu : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public Menu()
        {
            InitializeComponent();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;

            ligarDB.Open();

            command.CommandText = "SELECT nome FROM CLIENTE";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = textonome.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string nome = reader["nome"].ToString();

            textonome.Text = nome;
        }

        private void Perfil_Click(object sender, EventArgs e)
        {

        }

        private void marcar_Click(object sender, EventArgs e)
        {

        }

        private void textonome_Click(object sender, EventArgs e)
        {
            

            
        }
    }
}
