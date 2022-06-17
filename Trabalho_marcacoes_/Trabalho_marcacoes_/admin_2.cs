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
    public partial class admin_2 : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public admin_2()
        {
            InitializeComponent();

            string query = "SELECT * FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho ";
            string query2 = "SELECT * FROM profissao_tabela INNER JOIN especialidade_tabela on especialidade_tabela.profissao  = profissao_tabela.id_profissao";

            SqlCommand cmd = new SqlCommand(query, ligarDB);
            SqlCommand cmd2 = new SqlCommand(query2, ligarDB);

            ligarDB.Close();

            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            cp_mos.Items.Clear();

            while (Reader.Read())
            {

                string[] codip = new string[] { Reader["codigo_postal"].ToString(), Reader["distrito"].ToString(), Reader["conselho"].ToString() };
                cp_mos.Items.Add(new ListViewItem(codip));
            }

            ligarDB.Close();
            Reader.Close();

            ligarDB.Open();
            Reader = cmd2.ExecuteReader();

            especialidade_mos.Items.Clear();

            while (Reader.Read())
            {

                string[] especialidade = new string[] { Reader["profissao"].ToString(), Reader["especialidade"].ToString()};
                especialidade_mos.Items.Add(new ListViewItem(especialidade));
            }

            ligarDB.Close();
            Reader.Close();

        }

        private void cp_apagar_Click(object sender, EventArgs e)
        {
            
        }

        private void cp_adicionar_Click(object sender, EventArgs e)
        {
            admin_cp principal = new admin_cp();
            this.Hide();
            principal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void apa_espe_Click(object sender, EventArgs e)
        {

        }

        private void add_espe_Click(object sender, EventArgs e)
        {

        }
    }
}
