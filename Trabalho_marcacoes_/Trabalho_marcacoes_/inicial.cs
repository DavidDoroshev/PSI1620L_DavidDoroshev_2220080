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
        public int teste { get; set; }

        public inicial()
        {        
            InitializeComponent();
            
        }

        private void iniciar_botoa_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            teste = 3;
        }

        private void cliente_botao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            teste = 1;
        }

        private void trabalhador_botao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            teste = 2;
        }

        private void inicial_Load(object sender, EventArgs e)
        {

        }
    }
}
