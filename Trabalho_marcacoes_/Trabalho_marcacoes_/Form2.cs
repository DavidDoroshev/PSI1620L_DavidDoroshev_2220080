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
    public partial class Form2 : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ligarDB"].ConnectionString;
        static SqlConnection ligarDB = new SqlConnection(connectionString);


        public Form2()
        {
            try
            {
                ligarDB.Open();
                InitializeComponent();
                SqlCommand command = new SqlCommand();
                command.Connection = ligarDB;
                /* SqlDataReader commandReader = command.ExecuteReader();
                commandReader.Read(); */
                command.CommandText = "select * from codigo_postal";
                SqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    comboBox1.Items.Add(reader["codigo_postal"].ToString());
                }
                ligarDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guardar_cliente_Click(object sender, EventArgs e)
        {
            ligarDB.Open();
            SqlCommand command = new SqlCommand();

            command.Connection = ligarDB;

            command.CommandText = "SELECT * FROM codigo_postal WHERE Nome = @nome";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = nome_guardar;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = password_guardar;
            command.Parameters.Add("@codigo_postal_cliente", System.Data.SqlDbType.VarChar).Value = comboBox1;
            

            


        }

        private void voltar_iniciar_Click(object sender, EventArgs e)
        {
            Form1 voltar = new Form1();
            voltar.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
