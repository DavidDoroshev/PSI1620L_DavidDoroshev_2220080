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

        private void apagar_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            try
            {
                string query2 = "DELETE marcacoes_cliente FROM marcacoes_cliente RIGHT JOIN cliente on marcacoes_cliente.nome_cliente_id = cliente.id WHERE cliente.id = @id";
                SqlCommand cm = new SqlCommand(query2, ligarDB);
                cm.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = cliente_mos.SelectedItems[0].SubItems[0].Text.ToString();

                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                reader.Close();


                string query = "  DELETE FROM cliente WHERE id = @id ";
                SqlCommand cmd = new SqlCommand(query, ligarDB);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = cliente_mos.SelectedItems[0].SubItems[0].Text.ToString();

                reader = cmd.ExecuteReader();

                reader.Read();
                reader.Close();



                string query3 = "select * from cliente";
                SqlCommand cmd3 = new SqlCommand(query3, ligarDB);

                reader = cmd3.ExecuteReader();

                cliente_mos.Items.Clear();

                while (reader.Read())
                {

                    string[] cliente = new string[] { reader["id"].ToString(), reader["nome"].ToString(), reader["password"].ToString(), reader["codigo_postal_cliente"].ToString() };
                    cliente_mos.Items.Add(new ListViewItem(cliente));
                }

                ligarDB.Close();
                reader.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Cliente apagado com sucesso !!");
            

            ligarDB.Close();
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            admin_cliente ir = new admin_cliente();
            this.Hide();
            ir.Show();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {

        }

        private void apagar_tra_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            try
            {
                string query2 = "DELETE marcacoes_cliente  FROM marcacoes_cliente INNER JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id WHERE trabalhadores.id = @id";
                SqlCommand cm = new SqlCommand(query2, ligarDB);
                cm.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = trabalhador_mos.SelectedItems[0].SubItems[0].Text.ToString();

                SqlDataReader reader = cm.ExecuteReader();
                reader.Read();
                reader.Close();


                string query = "  DELETE FROM trabalhadores WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, ligarDB);
                cmd.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = trabalhador_mos.SelectedItems[0].SubItems[0].Text.ToString();

                reader = cmd.ExecuteReader();

                reader.Read();
                reader.Close();



                string query3 = "select * from trabalhadores";
                SqlCommand cmd3 = new SqlCommand(query3, ligarDB);

                reader = cmd3.ExecuteReader();


                while (reader.Read())
                {
                    string[] trabalhador = new string[] { reader["id"].ToString(), reader["nome"].ToString(), reader["password"].ToString(), reader["codigo_postal_trabalhador"].ToString(), reader["especialidade_tabela_trabalhador"].ToString() };
                    trabalhador_mos.Items.Add(new ListViewItem(trabalhador));
                }

                ligarDB.Close();
                reader.Close();

                ligarDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Trabalhador apagado com sucesso !!");



        }

        private void add_tra_Click(object sender, EventArgs e)
        {
            admin_trabalhador ir = new admin_trabalhador();
            this.Hide();
            ir.Show();
        }

        private void apagar_mar_Click(object sender, EventArgs e)
        {
            ligarDB.Open();

            string query2 = "DELETE marcacoes_cliente  FROM marcacoes_cliente WHERE id = @id";
            SqlCommand cm = new SqlCommand(query2, ligarDB);
            cm.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = marcacoes_mos.SelectedItems[0].SubItems[0].Text.ToString();

            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            reader.Close();

            MessageBox.Show("Marcação apagada com sucesso !!!");

            ligarDB.Close();
        }

        private void add_marca_Click(object sender, EventArgs e)
        {
            admin_marcar ir = new admin_marcar();
            this.Hide();
            ir.Show();
        }
    }
}
