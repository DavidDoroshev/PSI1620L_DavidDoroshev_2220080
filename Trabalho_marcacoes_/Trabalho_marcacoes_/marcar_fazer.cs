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
    public partial class marcar_fazer : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public marcar_fazer()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT * FROM trabalhadores";
            comando.Connection = ligarDB;

            ligarDB.Open();
            SqlDataReader Reader = comando.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {

                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString(), Reader["codigo_postal_trabalhador"].ToString() };
                mostrar.Items.Add(new ListViewItem(bomdia));
            }

            Reader.Close();
            ligarDB.Close();

            int itemHeight = 20;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            mostrar.SmallImageList = imgList;
        }

        private void mostrar_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
                e.Cancel = true;
                e.NewWidth = mostrar.Columns[e.ColumnIndex].Width;
        }

        private void Marcar_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;

            ligarDB.Open();

            int i;
            for ( i = 0; i<3; i++)
            {
                MessageBox.Show(mostrar.SelectedItems[0].SubItems[i].Text);
            }
            MessageBox.Show(horas_guardar.Text + tempo_guardar.Text);

            


            command.CommandText = "INSERT INTO marcacaoes_cliente(dia_marcacao, hora, codigo_postal_marcar, nome_cliente_id, nome_trabalhador_id, especialidade_marcacao ) VALUES(@dia, @hora, @codigo_postal,@nome_cliente, @nome_trabalhador, @especialidade)";
            command.Parameters.Add("@dia", System.Data.SqlDbType.VarChar).Value = tempo_guardar.Text;
            command.Parameters.Add("@hora", System.Data.SqlDbType.VarChar).Value = horas_guardar.Text;
            command.Parameters.Add("@codigo_postal", System.Data.SqlDbType.VarChar).Value = mostrar.Items[i].SubItems[3].ToString();
            //command.Parameters.Add("@nome_cliente", System.Data.SqlDbType.VarChar).Value = ();
            command.Parameters.Add("@nome_trabalhador", System.Data.SqlDbType.VarChar).Value = mostrar.Items[i].SubItems[1].ToString();
            command.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = mostrar.Items[i].SubItems[2].ToString();


            command.ExecuteNonQuery();

            ligarDB.Close();

            MessageBox.Show("Trabalhador adicionado com sucesso");


        }

       
    }
}
