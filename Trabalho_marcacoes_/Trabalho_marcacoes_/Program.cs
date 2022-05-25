using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_marcacoes_
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            inicial login = new inicial();

            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                switch (login.teste)
                {
                    case 1:
                        Application.Run(new criar_conta());
                        break;

                    case 2:
                        Application.Run(new trabalhador_criar());
                        break;

                    default:
                        Application.Run(new Iniciar_Sessao());
                        break;
                }
            }
        }
    }
}
