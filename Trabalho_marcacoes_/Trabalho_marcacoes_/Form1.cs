using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Trabalho_marcacoes_
{
    
    public partial class Form1 : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
            iniciar_botoa.Select();
        }

        private void iniciar_botoa_Click(object sender, EventArgs e)
        {
            Iniciar_Sessao voltar = new Iniciar_Sessao();
            voltar.Show();
            this.Hide();
        }

        private void cliente_botao_Click(object sender, EventArgs e)
        {
            Form2 ligar = new Form2();
            ligar.Show();
            this.Hide();
        }

        private void trabalhador_botao_Click(object sender, EventArgs e)
        {

        }
    }
}
