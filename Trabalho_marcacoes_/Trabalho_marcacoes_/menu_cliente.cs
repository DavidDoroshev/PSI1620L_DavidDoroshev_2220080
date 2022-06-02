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
    public partial class menu_cliente : Form
    {

        public menu_cliente()
        {
            InitializeComponent();
        }

        private void Perfil_Click(object sender, EventArgs e)
        {
            cliente_perfil ir = new cliente_perfil();
            ir.Show();
            this.Close();
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

        private void Menu_Load_1(object sender, EventArgs e)
        {
            current_user.Text = Iniciar_Sessao.utilizador;
        }

        private void ver_marca_Click(object sender, EventArgs e)
        {
            ver_marcacoes ir = new ver_marcacoes();
            this.Hide();
            ir.Show();
        }
    }
}
