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

            command.Connection = conexao;

            command.CommandText = "SELECT * FROM filmes WHERE Nome = @nome";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = valor_selecionado;

            conexao.Open();

            SqlDataReader commandReader = command.ExecuteReader();
            commandReader.Read();

        }

        private void voltar_iniciar_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Hide();
        }
    }
}
