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
    public partial class admin_espe : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);

        public admin_espe()
        {
            InitializeComponent();

            ligarDB.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;
            command.CommandText = "select distinct * from profissao_tabela";

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                escolher_pro.Items.Add(reader["profissao"].ToString());
            }
            ligarDB.Close();
            reader.Close();
        }

        private void escolher_pro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ligarDB.Close();

            SqlCommand command = new SqlCommand();
            command.Connection = ligarDB;



            ligarDB.Open();
            command.CommandText = "SELECT especialidade_tabela.especialidade FROM profissao_tabela INNER JOIN especialidade_tabela on especialidade_tabela.profissao  = profissao_tabela.id_profissao WHERE profissao_tabela.profissao = @profissao";


            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar).Value = add_espe.Text;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                escolher_pro.Items.Add(reader.GetString(0));
            }

            ligarDB.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ligarDB.Close();

            ligarDB.Open();            
        }
    }
}
