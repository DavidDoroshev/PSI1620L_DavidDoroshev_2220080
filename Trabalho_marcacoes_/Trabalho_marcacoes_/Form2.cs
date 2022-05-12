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
    public partial class Form2 : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void nome_guardar_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_guardar_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_cliente_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;

            command.CommandText = "SELECT * FROM filmes WHERE Nome = @nome";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_guardar;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_guardar;
            command.Parameters.Add("@codigo_postal_cliente", System.Data.SqlDbType.VarChar).Value = password_guardar;
            ligarDB.Open();

            SqlDataReader commandReader = command.ExecuteReader();
            commandReader.Read();

        }

        private void voltar_iniciar_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
