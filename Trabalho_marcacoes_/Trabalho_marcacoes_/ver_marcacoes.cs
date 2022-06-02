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
    public partial class ver_marcacoes : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);

        public ver_marcacoes()
        {
            InitializeComponent();


            SqlCommand comando = new SqlCommand();
            comando.Connection = ligarDB;



            string query = " SELECT marcacoes_cliente.dia_marcacao, marcacoes_cliente.hora, trabalhadores.nome, marcacoes_cliente.especialidade_marcacao FROM marcacoes_cliente LEFT JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id ";

            SqlCommand cmd = new SqlCommand(query, ligarDB);


            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {

                string[] bomdia = new string[] { Reader["trabalhadores.nome"].ToString(), Reader["marcacoes_cliente.especialidade_marcacao"].ToString(), Reader["marcacoes_cliente.dia_marcacao"].ToString(), Reader["marcacoes_cliente.hora"].ToString() };
                mostrar.Items.Add(new ListViewItem(bomdia));
            }

            ligarDB.Close();
            Reader.Close();
        }
    }
}
