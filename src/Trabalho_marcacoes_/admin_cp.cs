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
    public partial class admin_cp : Form
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        private static SqlConnection ligarDB = new SqlConnection(connectionString);
        public admin_cp()
        {
            InitializeComponent();
        }

        private void guardar_cp_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();

            if (conselho.Text.Trim() == "")
            {
                MessageBox.Show("Têm de colocar Conselho");
                return;
            }
            if (distrito.Text.Trim() == "")
            {
                MessageBox.Show("Têm de colocar Distrito");
                return;
            }
            if (cp_guardar.Text.Trim() == "")
            {
                MessageBox.Show("Têm de colocar Código Postal");
                return;
            }



            DialogResult dialogResult  = MessageBox.Show("Têm mesmo a certeza que quer adicionar este código postal", "Verificar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "INSERT INTO conselho_tabela(conselho) VALUES (@conselho)";

                string query2 = "INSERT INTO distrito_tabela(distrito, conselho_distrito) VALUES (@distrito , @conselho)";

                string query3 = "INSERT INTO codigo_postal(codigo_postal, distrito_codigo) VALUES (@codigo , @distrito)";


                SqlCommand cmd = new SqlCommand(query, ligarDB);
                SqlCommand cmd2 = new SqlCommand(query2, ligarDB);
                SqlCommand cmd3 = new SqlCommand(query3, ligarDB);


                cmd.Parameters.Add("@conselho", SqlDbType.VarChar).Value = conselho.Text.Trim();

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();

                cmd2.Parameters.Add("@conselho", SqlDbType.VarChar).Value = conselho.Text.Trim();
                cmd2.Parameters.Add("@distrito", SqlDbType.VarChar).Value = distrito.Text.Trim();

                reader = cmd2.ExecuteReader();
                reader.Read();
                reader.Close();

                cmd3.Parameters.Add("@distrito", SqlDbType.VarChar).Value = distrito.Text.Trim();
                cmd3.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cp_guardar.Text.Trim();

                reader = cmd3.ExecuteReader();
                reader.Read();
                reader.Close();


                MessageBox.Show("CP guardado com sucesso");
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            ligarDB.Close();
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            admin_2 ir = new admin_2();
            this.Close();
            ir.Show();
        }
    }
}
