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
    
    public partial class menu_inicial : Form 
    {
        //public int teste { get; set; }

        public menu_inicial()
        {        
            InitializeComponent();
        }

        private void iniciar_botoa_Click(object sender, EventArgs e)
        {
            Iniciar_Sessao ir = new Iniciar_Sessao();
            this.Hide();
            ir.Show();
            
            
            

            //this.DialogResult = DialogResult.OK;
            //teste = 3;
        }

        private void cliente_botao_Click(object sender, EventArgs e)
        {
            criar_conta ir = new criar_conta();
            this.Hide();
            ir.Show();
            //this.DialogResult = DialogResult.OK;
            //teste = 1;
        }

        private void trabalhador_botao_Click(object sender, EventArgs e)
        {
            criar_trabalhador ir = new criar_trabalhador();
            this.Hide();
            ir.Show();
            //this.DialogResult = DialogResult.OK;
            //teste = 2;
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
