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



            string query = " SELECT marcacoes_cliente.dia_marcacao, marcacoes_cliente.hora, trabalhadores.nome, marcacoes_cliente.especialidade_marcacao FROM marcacoes_cliente LEFT JOIN trabalhadores on marcacoes_cliente.nome_trabalhador_id = trabalhadores.id RIGHT JOIN cliente on marcacoes_cliente.nome_cliente_id = cliente.id WHERE cliente.nome = '" + Iniciar_Sessao.utilizador + "'";

            SqlCommand cmd = new SqlCommand(query, ligarDB);


            ligarDB.Open();
            SqlDataReader Reader = cmd.ExecuteReader();

            mostrar.Items.Clear();

            while (Reader.Read())
            {
                
                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_marcacao"].ToString(), ((DateTime)Reader["dia_marcacao"]).ToShortDateString(), Reader["hora"].ToString() };
                mostrar.Items.Add(new ListViewItem(bomdia));
            }

            ligarDB.Close();
            Reader.Close();
            int itemHeight = 20;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            mostrar.SmallImageList = imgList;

        }
    }
}
