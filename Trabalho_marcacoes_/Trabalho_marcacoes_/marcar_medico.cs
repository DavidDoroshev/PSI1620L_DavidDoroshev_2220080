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
    public partial class marcar_medico : Form
    {

        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public marcar_medico()
        {
            InitializeComponent();

            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SELECT * FROM trabalhadores INNER JOIN especialidade_tabela on trabalhadores.especialidade_tabela_trabalhador = especialidade_tabela.especialidade inner join profissao_tabela on especialidade_tabela.profissao = profissao_tabela.id_profissao where profissao_tabela.profissao like 'Medico'";
            comando.Connection = ligarDB;

            ligarDB.Open();
            SqlDataReader Reader = comando.ExecuteReader();

            mostrar_medico.Items.Clear();

            while (Reader.Read())
            {

                string[] bomdia = new string[] { Reader["nome"].ToString(), Reader["especialidade_tabela_trabalhador"].ToString(), Reader["codigo_postal_trabalhador"].ToString() };
                mostrar_medico.Items.Add(new ListViewItem(bomdia));
            }

            Reader.Close();
            ligarDB.Close();

            int itemHeight = 20;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, itemHeight);
            mostrar_medico.SmallImageList = imgList;
        }

        private void mostrar_medico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
