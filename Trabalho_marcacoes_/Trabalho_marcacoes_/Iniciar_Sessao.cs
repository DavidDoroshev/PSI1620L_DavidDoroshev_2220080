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
    public partial class Iniciar_Sessao : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public Iniciar_Sessao()
        {
            InitializeComponent();

            password_entrar.UseSystemPasswordChar = true;

            mostrar_.Appearance = Appearance.Button;
        }

        private async void entrar_menu_Click(object sender, EventArgs e)
        {

            ligarDB.Open();
            string query = "SELECT * FROM trabalhadores WHERE nome = @nome AND password = @password";
            SqlCommand cmd = new SqlCommand(query, ligarDB);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password_entrar.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            await reader.ReadAsync();

            if (reader.HasRows)
            {
                menu_cliente principal = new menu_cliente();
                this.Hide();
                principal.Show();
                ligarDB.Close();
            }
            else
            {
                query = "SELECT * FROM cliente WHERE nome = @nome AND password = @password";
                cmd = new SqlCommand(query, ligarDB);
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password_entrar.Text;
                reader.Close();
                reader = cmd.ExecuteReader();
                await reader.ReadAsync();
                if (reader.HasRows)
                {
                    menu_trabalhador principal = new menu_trabalhador();
                    this.Hide();
                    principal.Show();
                    ligarDB.Close();
                }
                
                else
                {
                    MessageBox.Show("Nome ou a Password está incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    nome_entrar.Text = "";
                    password_entrar.Text = "";
                    nome_entrar.Select();
                    ligarDB.Close();
                }
            }
        }
      private void mostrar__CheckedChanged(object sender, EventArgs e)
        {
                if (mostrar_.Checked)
                {
                password_entrar.UseSystemPasswordChar = false;
                }
                else
                {
                password_entrar.UseSystemPasswordChar = true;
                }    
        }

        private void Iniciar_Sessao_Load(object sender, EventArgs e)
        {

        }
    }
}
