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
        public Menu()
        {
            InitializeComponent();

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

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        

        private void marcar_estetica_Click(object sender, EventArgs e)
        {
            marcar_estetica ir = new marcar_estetica();
            ir.Show();
            this.Close();
        }

        private void ir_medico_Click(object sender, EventArgs e)
        {
            marcar_medico ir = new marcar_medico();
            ir.Show();
            this.Close();
        }
    }
}
