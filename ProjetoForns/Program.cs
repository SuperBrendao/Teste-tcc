using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForns
{
    internal static class Program
    {

        public static bool voltar;
        public static string acessoRegular;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            do
            {
                TelaLogin login = new TelaLogin();
                voltar = false;
                if (login.ShowDialog() == DialogResult.OK) Application.Run(new Form1()); ;
            } 
            while (voltar == true);
        }

      
    }
}
