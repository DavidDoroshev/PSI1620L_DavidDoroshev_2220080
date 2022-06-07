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

            string nome = nome_entrar.Text;
  
        }

        public static string utilizador = "";
        public static string trabalhador = "";
        public static string pass_utilizador = "";
        public static string pass_trabalhador = "";
        private async void entrar_menu_Click(object sender, EventArgs e)
        {

            ligarDB.Open();
            string query = "SELECT * FROM trabalhadores WHERE nome = @nome AND password = @password ";
            SqlCommand cmd = new SqlCommand(query, ligarDB);
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password_entrar.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            await reader.ReadAsync();

            if (reader.HasRows)
            {
                trabalhador = nome_entrar.Text;
                menu_trabalhador principal = new menu_trabalhador();
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
                    utilizador = nome_entrar.Text;
                    pass_utilizador = password_entrar.Text;
                    menu_cliente principal = new menu_cliente();
                    this.Hide();
                    principal.Show();
                    ligarDB.Close();
                }

                else
                {

                    query = "SELECT * FROM admin WHERE nome = @nome AND pass = @pass";
                    cmd = new SqlCommand(query, ligarDB);
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = password_entrar.Text;
                    reader.Close();
                    reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        utilizador = nome_entrar.Text;
                        pass_utilizador = password_entrar.Text;
                        admin ir = new admin();
                        this.Hide();
                        ir.Show();
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

            //string query = "SELECT * FROM trabalhadores WHERE nome = @nome AND password = @password ";
            //SqlCommand cmd = new SqlCommand(query, ligarDB);
            //cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
            //cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password_entrar.Text;
            //SqlDataReader reader = cmd.ExecuteReader();
            //await reader.ReadAsync();

            //if (reader.HasRows)
            //{

            //    trabalhador = nome_entrar.Text;
            //    menu_trabalhador principal = new menu_trabalhador();
            //    this.Hide();
            //    principal.Show();
            //    ligarDB.Close();
            //}
            //else
            //{

            //    MessageBox.Show("Nome ou a Password está incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    nome_entrar.Text = "";
            //    password_entrar.Text = "";
            //    nome_entrar.Select();
            //    query = "SELECT * FROM cliente WHERE nome = @nome AND password = @password";
            //    cmd = new SqlCommand(query, ligarDB);
            //    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome_entrar.Text;
            //    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password_entrar.Text;
            //    reader.Close();
            //    reader = cmd.ExecuteReader();
            //    await reader.ReadAsync();
            //    if (reader.HasRows)
            //    {
            //        menu_cliente principal = new menu_cliente();
            //        this.Hide();
            //        principal.Show();
            //        ligarDB.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Nome ou a Password está incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        nome_entrar.Text = "";
            //        password_entrar.Text = "";
            //        nome_entrar.Select();
            //        ligarDB.Close();
            //    }
            //}
        }

        private void ver_CheckedChanged(object sender, EventArgs e)
        {
            if (ver.Checked)
            {
                password_entrar.UseSystemPasswordChar = false;
            }
            else
            {
                password_entrar.UseSystemPasswordChar = true;
            }
        }

    }
}
