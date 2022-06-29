using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_marcacoes_
{
    public partial class menu_trabalhador : Form
    {
        public menu_trabalhador()
        {
            InitializeComponent();
            trabalhador_atual.Text = Iniciar_Sessao.trabalhador;
        }

        private void perfil_trabalhador_Click(object sender, EventArgs e)
        {
            perfil_trabalhador ir = new perfil_trabalhador();
            this.Hide();
            ir.Show();                        
        }
        private void ver_marcacoes_trabalhador_Click(object sender, EventArgs e)
        {
            marcacoes_trabalhador ir = new marcacoes_trabalhador();
            this.Hide();
            ir.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
