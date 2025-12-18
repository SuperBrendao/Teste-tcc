using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForns
{
    public partial class Cabesario : UserControl
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

      
        public Cabesario(string naoMostar1="", string naoMostar2 = "", string naoMostar3="")
        {
            InitializeComponent();

            if (naoMostar1 == "VoltarLogin" || naoMostar2 == "VoltarLogin" || naoMostar3 == "VoltarLogin") 
            {
                Voltar.Visible= false;
            }
            if (naoMostar1 == "VoltarFuncionario" || naoMostar2 == "VoltarFuncionario"||naoMostar3 == "VoltarFuncionario")
            {
                VoltarFuncionario.Visible = false;
            }

    
        }
       

        private void Cabesario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.ParentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Maximized;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

      
        private void ChamarSubTela(UserControl tela, string tipo = "")
        {
            Form1 formPai = this.ParentForm as Form1;

            if (formPai != null)
            {
                formPai.ChamarMineTela(tela, nivelAcesso: tipo);
            }
        }

        private void VoltarFuncionario_DoubleClick(object sender, EventArgs e)
        {
            Form1.BostarLogoParaEstoque = false;
            ChamarSubTela(new TelaIntermediaria());
        }

        private void VoltarLLogin_DoubleClick(object sender, EventArgs e)
        {
            Form1.BostarLogoParaEstoque = false;
            Program.voltar = true;
            this.ParentForm.Close();
        }

        private void VoltarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
