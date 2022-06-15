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
    
    public partial class marcacoes_trabalhador : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public marcacoes_trabalhador()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;



            string query = " SELECT marcacoes_cliente.dia_marcacao, marcacoes_cliente.hora, cliente.nome FROM marcacoes_cliente LEFT JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id RIGHT JOIN cliente on marcacoes_cliente.nome_cliente_id = cliente.id WHERE trabalhadores.nome = '"+ Iniciar_Sessao.trabalhador +"' ";

            SqlCommand cmd = new SqlCommand(query, ligarDB);

            ligarDB.Close();

            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {

                string[] bomdia = new string[] { Reader["nome"].ToString(), ((DateTime)Reader["dia_marcacao"]).ToShortDateString(), Reader["hora"].ToString() };
                mostrar.Items.Add(new ListViewItem(bomdia));
            }

            ligarDB.Close();
            Reader.Close();
        }


        private void voltar_Click(object sender, EventArgs e)
        {
            menu_trabalhador voltar = new menu_trabalhador();
            this.Hide();
            voltar.Show();
        }
    }
}
