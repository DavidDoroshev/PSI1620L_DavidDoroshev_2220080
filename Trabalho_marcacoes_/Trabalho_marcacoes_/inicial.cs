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
    
    public partial class inicial : Form 
    {
        static string _connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection db = new SqlConnection(_connectionString);

        public inicial()
        {
            try
            {
                db.Open();
            }
            catch (Exception)
            {

            }
            InitializeComponent();
            
        }

        private void iniciar_botoa_Click(object sender, EventArgs e)
        {
            Iniciar_Sessao voltar = new Iniciar_Sessao();
            voltar.Show();
            this.Hide();
        }

        private void cliente_botao_Click(object sender, EventArgs e)
        {
            criar_conta ligar = new criar_conta();
            ligar.Show();
            this.Hide();
        }

        private void trabalhador_botao_Click(object sender, EventArgs e)
        {
            trabalhador_criar ligar = new trabalhador_criar();
            ligar.Show();
            this.Hide();
        }

    }
}
