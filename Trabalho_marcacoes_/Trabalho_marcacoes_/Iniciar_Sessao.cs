﻿using System;
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
        //public static string connectionString = ConfigurationManager.ConnectionStrings["cnPSI"].ConnectionString;
        //public static SqlConnection ligarDB = new SqlConnection(connectionString);

        public Iniciar_Sessao()
        {
            InitializeComponent();
        }

        private void entrar_menu_Click(object sender, EventArgs e)
        {
            //ligarDB.Open();

            //string query = "SELECT * FROM cliente WHERE nome = '" + nome_entrar.Text + "' AND password= '" + password_entrar.Text + "' ";
            //SqlDataAdapter dp = new SqlDataAdapter(query, ligarDB);
            //DataTable dt = new DataTable();
            //dp.Fill(dt);
            //ligarDB.Close();

            //if (dt.Rows.Count == 1)
            //{

            //    Form2 principal = new Form2();
            //    this.Hide();
            //    principal.Show();
            //}
            //else
            //{

            //    MessageBox.Show("Nome ou a Password está incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    nome_entrar.Text = "";
            //    password_entrar.Text = "";
            //    nome_entrar.Select();
            //}
        }

        private void nome_entrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_entrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}