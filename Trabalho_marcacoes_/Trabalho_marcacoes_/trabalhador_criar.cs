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
    public partial class trabalhador_criar : Form
    {
        public trabalhador_criar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicial voltar = new inicial();
            voltar.Show();
            this.Hide();
        }
    }
}
