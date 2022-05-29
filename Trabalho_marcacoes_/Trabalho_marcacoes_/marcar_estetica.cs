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
    public partial class marcar_estetica : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public marcar_estetica()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;
            comando.CommandText = "SELECT * FROM trabalhadores INNER JOIN especialidade_tabela on trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade inner join profissao_tabela on especialidade_tabela.profissao = profissao_tabela.id_profissao where profissao_tabela.profissao like 'Estética'";

            ligarDB.Open();
            SqlDataReader Reader = comando.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {

                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString(), Reader["codigo_postal_trabalhador"].ToString() };
                mostrar.Items.Add(new ListViewItem(bomdia));
            }

            ligarDB.Close();
            Reader.Close(); 

            ligarDB.Close();
            ligarDB.Open();
            comando.CommandText = "select * from codigo_postal";


            Reader = comando.ExecuteReader();
            while (Reader.Read())
            {

                codigo_pesquisar.Items.Add(Reader["codigo_postal"].ToString());
            }
            ligarDB.Close();
            Reader.Close();

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
           //TODO- guardar a marcação 
            int i;
            for (i = 0; i < 3; i++)
            {
                MessageBox.Show(mostrar.SelectedItems[0].SubItems[i].Text);
            }
            MessageBox.Show(horas_guardar.Text + tempo_guardar.Text);

            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;
            ligarDB.Close();
            ligarDB.Open();

            string query = "INSERT INTO marcacaoes_cliente(dia_marcacao, hora, nome_cliente_id, nome_trabalhador_id, especialidade_marcacao ) VALUES(@dia, @hora ,@nome_cliente, @nome_trabalhador, @especialidade)";
            SqlCommand cmd = new SqlCommand(query, ligarDB);
            cmd.Parameters.Add("@dia", System.Data.SqlDbType.VarChar).Value = tempo_guardar.Text;
            cmd.Parameters.Add("@hora", System.Data.SqlDbType.VarChar).Value = horas_guardar.Text;
            cmd.Parameters.Add("@nome_cliente", System.Data.SqlDbType.VarChar).Value = Iniciar_Sessao.utilizador;
            cmd.Parameters.Add("@nome_trabalhador", System.Data.SqlDbType.VarChar).Value = mostrar.Items[0].SubItems[0].ToString();
            cmd.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = mostrar.Items[0].SubItems[1].ToString();

            
            command.ExecuteNonQuery();

            ligarDB.Close();


            MessageBox.Show("Marcação feita com sucesso");


        }

        private void codigo_pesquisar_Enter(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            try
            {

                ligarDB.Open();

                command.CommandText = "SELECT codigo_postal, distrito_tabela.distrito, conselho_tabela.conselho FROM codigo_postal INNER JOIN distrito_tabela ON distrito_codigo = distrito_tabela.distrito INNER JOIN conselho_tabela ON conselho_distrito = conselho_tabela.conselho WHERE codigo_postal = @codigo";

                command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_pesquisar.Text;

                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void codigo_pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void horas_guardar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
