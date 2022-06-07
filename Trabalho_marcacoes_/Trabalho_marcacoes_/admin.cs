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
using System.Text.RegularExpressions;

namespace Trabalho_marcacoes_
{
    public partial class admin : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public admin()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;



            string query = "select * from cliente";
            string query2 = "select * from trabalhadores";
            string query3 = "select * from marcacoes_cliente";

            SqlCommand cmd = new SqlCommand(query, ligarDB);
            SqlCommand cmd2 = new SqlCommand(query2, ligarDB);
            SqlCommand cmd3 = new SqlCommand(query3, ligarDB);

            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            cliente_mos.Items.Clear();

            while (Reader.Read())
            {

                string[] cliente = new string[] { Reader["id"].ToString(), Reader["nome"].ToString(), Reader["password"].ToString(), Reader["codigo_postal_cliente"].ToString() };
                cliente_mos.Items.Add(new ListViewItem(cliente));
            }

            ligarDB.Close();
            Reader.Close();

            ligarDB.Open();
            Reader = cmd2.ExecuteReader();

            trabalhador_mos.Items.Clear();

            while (Reader.Read())
            {

                string[] trabalhador = new string[] { Reader["id"].ToString(), Reader["nome"].ToString(), Reader["password"].ToString(), Reader["codigo_postal_trabalhador"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString() };
                trabalhador_mos.Items.Add(new ListViewItem(trabalhador));
            }

            ligarDB.Close();
            Reader.Close();

            ligarDB.Open();
            Reader = cmd3.ExecuteReader();

            marcacoes_mos.Items.Clear();

            while (Reader.Read())
            {

                string[] marcacao = new string[] { Reader["id"].ToString(), Reader["nome_cliente_id"].ToString(), Reader["nome_trabalhador_id"].ToString(), Reader["especialidade_marcacao"].ToString(), ((DateTime)Reader["dia_marcacao"]).ToShortDateString(), Reader["hora"].ToString() };
                marcacoes_mos.Items.Add(new ListViewItem(marcacao));
            }

            ligarDB.Close();
            Reader.Close();
        }

        private void cliente_mos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = cliente_mos.Columns[e.ColumnIndex].Width;




        }

        private void marcacoes_mos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = cliente_mos.Columns[e.ColumnIndex].Width;



        }

        private void trabalhador_mos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = cliente_mos.Columns[e.ColumnIndex].Width;



        }
    }
}
