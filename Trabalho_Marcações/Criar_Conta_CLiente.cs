using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trabalho_Marcações
{
    public partial class Criar_Conta_CLiente : Form
    {
        private static string _connectionString = @"Data Source=devlab.thenotepad.eu; Initial Catalog=PSI20L_DavidDoroshev_2220080; User ID=U2220080; Password=Cd/F+shZ;TrustServerCertificate=True";
        public Criar_Conta_CLiente()
        {
            InitializeComponent();
        }

        private void Criar_Conta_CLiente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 voltar = new Form1();
            voltar.Show();
            
        }

        private void Guardar_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void password_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void zona_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
