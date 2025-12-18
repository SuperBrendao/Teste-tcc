using System;
using System.Windows.Forms;

namespace ProjetoForns
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ChamarConsoleUser(new Cabesario(naoMostar1:"VoltarLogin",naoMostar2:"VoltarFuncionario"));
        }
        private void ChamarConsoleUser(Control Tela)
        {
            Controls.Add(Tela);
            Tela.Dock = DockStyle.Top;
        }
        private void BTM_Entrar_Click(object sender, EventArgs e)
        {
            if (TB_Nome.Text == "1" || TB_Nome.Text == "2" || TB_Nome.Text == "3" ) { 
                
                Program.acessoRegular=TB_Nome.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
