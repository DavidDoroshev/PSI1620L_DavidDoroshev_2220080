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


            
            string query = "SELECT * FROM trabalhadores INNER JOIN especialidade_tabela on trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade INNER JOIN profissao_tabela ON especialidade_tabela.profissao = profissao_tabela.id_profissao WHERE profissao_tabela.profissao like 'Estética' ";
            string query2 = "SELECT * FROM codigo_postal ";

            SqlCommand cmd = new SqlCommand(query, ligarDB);
            SqlCommand cmd2 = new SqlCommand(query2, ligarDB);


            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

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

            Reader = cmd2.ExecuteReader();
            while (Reader.Read())
            {

             codigo_pesquisar.Items.Add(Reader["codigo_postal"].ToString());         
             


            }
            ligarDB.Close();
            Reader.Close();
        }

        private void mostrar_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
                e.Cancel = true;
                e.NewWidth = mostrar.Columns[e.ColumnIndex].Width;
        }

        private void Marcar_Click(object sender, EventArgs e)
        {
          
            if(mostrar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Tem de selecionar algum trabalhador");
                return;
            }    

            var data = Convert.ToDateTime(tempo_guardar.Text);

            if (data < DateTime.Now)
            {
                MessageBox.Show("Não pode pôr essa data!!!");
                return;
            }

            Regex ver = new Regex("^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");

            var veri = horas_guardar.Text;

            if(!ver.IsMatch(veri))
            {
                MessageBox.Show("Não pode pôr essas horas!!!");
                return;
            }

            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;
            ligarDB.Close();
            ligarDB.Open();

            string query  = "INSERT INTO marcacoes_cliente(dia_marcacao, hora, nome_cliente_id, nome_trabalhador_id, especialidade_marcacao ) VALUES(@dia, @hora ,@id, @nome_trabalhador, @especialidade)";
            string query2 = "SELECT id FROM cliente WHERE nome = @id";
            string query3 = "SELECT id FROM trabalhadores WHERE nome = @nome";

            SqlCommand cmd = new SqlCommand(query, ligarDB);
            SqlCommand ns = new SqlCommand(query2, ligarDB);
            SqlCommand command2 = new SqlCommand(query3, ligarDB);

            ns.Parameters.Add("@id", SqlDbType.VarChar).Value = Iniciar_Sessao.utilizador;
            command2.Parameters.Add("@nome", SqlDbType.VarChar).Value = mostrar.SelectedItems[0].SubItems[0].Text.ToString();

            SqlDataReader reader = ns.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["id"]);
            reader.Close();

            reader = command2.ExecuteReader();
            reader.Read();

            int idtrabalhador = Convert.ToInt32(reader["id"]);
            reader.Close();

            cmd.Parameters.Add("@dia", System.Data.SqlDbType.Date).Value = tempo_guardar.Text;
            cmd.Parameters.Add("@hora", System.Data.SqlDbType.Time).Value = horas_guardar.Text;
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id; 
            cmd.Parameters.Add("@nome_trabalhador", System.Data.SqlDbType.VarChar).Value = idtrabalhador;
            cmd.Parameters.Add("@especialidade", System.Data.SqlDbType.VarChar).Value = mostrar.Items[0].SubItems[1].Text.ToString();

            cmd.ExecuteNonQuery();

            ligarDB.Close();


            MessageBox.Show("Marcação feita com sucesso");

            menu_cliente principal = new menu_cliente();
            this.Hide();
            principal.Show();
       

        }
        private void voltar_Click(object sender, EventArgs e)
        {
            menu_cliente principal = new menu_cliente();
            this.Hide();
            principal.Show();     
   
        }


        private void codigo_pesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;

            comando.CommandText = "SELECT * FROM trabalhadores INNER JOIN especialidade_tabela on trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade INNER JOIN profissao_tabela ON especialidade_tabela.profissao = profissao_tabela.id_profissao WHERE profissao_tabela.profissao like 'Estética' AND trabalhadores.codigo_postal_trabalhador = @codigo ";
            comando.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = codigo_pesquisar.SelectedItem.ToString();
            SqlDataReader Reader = comando.ExecuteReader();

            
            mostrar.Items.Clear();

            while (Reader.Read())
            {


                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString(), Reader["codigo_postal_trabalhador"].ToString() };

                mostrar.Items.Add(new ListViewItem(bomdia));
                
            }
            Reader.Close();
            ligarDB.Close();

        }

        private void proximo_CheckedChanged(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();

            string query = "SELECT * FROM trabalhadores INNER JOIN especialidade_tabela on trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade INNER JOIN profissao_tabela ON especialidade_tabela.profissao = profissao_tabela.id_profissao INNER JOIN codigo_postal on trabalhadores.codigo_postal_trabalhador = codigo_postal.codigo_postal INNER JOIN cliente on codigo_postal.codigo_postal = cliente.codigo_postal_cliente WHERE profissao_tabela.profissao like 'Estética' AND cliente.codigo_postal_cliente = ''";
            string query2 = "SELECT * FROM cliente WHERE codigo_postal_cliente = @codigo_cliente and nome = '" +Iniciar_Sessao.utilizador+ "' " ;

            SqlCommand cmd = new SqlCommand(query, ligarDB);
            SqlCommand cmd2 = new SqlCommand(query2, ligarDB);

            cmd.Parameters.Add("@codigo_cliente", System.Data.SqlDbType.VarChar).Value = Iniciar_Sessao.utilizador ;
            SqlDataReader Reader = cmd.ExecuteReader();
            Reader.Close();

            cmd2.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = "@codigo_cliente";
            Reader = cmd2.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {


                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString(), Reader["codigo_postal_trabalhador"].ToString() };

                mostrar.Items.Add(new ListViewItem(bomdia));

            }
            Reader.Close();
            ligarDB.Close();


        }
    }
}
