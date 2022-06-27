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
    public partial class marcacoes_cliente : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public marcacoes_cliente()
        {
            InitializeComponent();

            ligarDB.Close();
            ligarDB.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;


            string query = " SELECT marcacoes_cliente.id, marcacoes_cliente.dia_marcacao, marcacoes_cliente.hora, trabalhadores.nome, marcacoes_cliente.especialidade_marcacao FROM marcacoes_cliente INNER JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id INNER JOIN cliente on marcacoes_cliente.nome_cliente_id = cliente.id WHERE cliente.nome = '" + Iniciar_Sessao.utilizador + "'";

            comando.CommandText = query;
            SqlDataReader Reader = comando.ExecuteReader();

            mostrar_teste.Items.Clear();


            if(Reader.HasRows)
            {
                while (Reader.Read())
                {
                    string[] bomdia = new string[] { Reader["id"].ToString(), Reader["nome"].ToString(), Reader["especialidade_marcacao"].ToString(), ((DateTime)Reader["dia_marcacao"]).ToShortDateString(), Reader["hora"].ToString() };
                    mostrar_teste.Items.Add(new ListViewItem(bomdia));
                }
            }
            ligarDB.Close();
            Reader.Close();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            menu_cliente voltar = new menu_cliente();
            this.Hide();
            voltar.Show();
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();

            if (mostrar_teste.SelectedItems.Count == 0)
            {
                MessageBox.Show("Tem de selecionar uma marcação para apagar");
                return;
            }
            else
            {
                string query2 = "DELETE marcacoes_cliente  FROM marcacoes_cliente WHERE id = @id";
                SqlCommand cm = new SqlCommand(query2, ligarDB);
                cm.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = mostrar_teste.SelectedItems[0].SubItems[0].Text.ToString();

                cm.ExecuteNonQuery();

                cm.Parameters.Clear();

                string query3 = "select * from marcacoes_cliente";
                SqlCommand cmd3 = new SqlCommand(query3, ligarDB);

                
                SqlDataReader reader = cmd3.ExecuteReader();

                mostrar_teste.Items.Clear();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] marcacao = new string[] { Convert.ToInt32(reader["id"]).ToString(), reader["nome_cliente_id"].ToString(), reader["nome_trabalhador_id"].ToString(), reader["especialidade_marcacao"].ToString(), ((DateTime)reader["dia_marcacao"]).ToShortDateString(), reader["hora"].ToString() };
                        mostrar_teste.Items.Add(new ListViewItem(marcacao));
                    }
                }
                ligarDB.Close();
                reader.Close();

                MessageBox.Show("Marcação apagada com sucesso !!!");
            }
        }

        private void mostrar_teste_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = mostrar_teste.Columns[e.ColumnIndex].Width; 
        }
    }
}

