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

        private void mostrar_SelectedIndexChanged(object sender, EventArgs e)
        
        {
            MessageBox.Show("Nome: " + mostrar.SelectedItems[0].SubItems[0].Text.ToString());
            MessageBox.Show("Especialidade: " + mostrar.SelectedItems[0].SubItems[1].Text.ToString());
            MessageBox.Show("Código Postal: " + mostrar.SelectedItems[0].SubItems[2].Text.ToString());

            mostrar.SelectedItems.Clear();
            mostrar.SelectedIndices.Clear();
        }

        
    }
}
