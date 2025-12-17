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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            ChamarBase();
        }

        private void ChamarBase()
        { 
            if (Program.acessoRegular == "1")//Gerente
            {
                ChamarConsoleUser(new MenuGerente(), "Menu");
            }
            else if (Program.acessoRegular == "2")//Estoque
            {
                ChamarConsoleUser(new MenuEstoque(),"Menu");
            }
            else//Estoquista 
            {
                ChamarConsoleUser(new TelaVenda(), "");
            }

            ChamarConsoleUser(new Cabesario(), "cabesario");
        }

        private void ChamarConsoleUser(Control Tela,string tipo)
        {
            Controls.Add(Tela);
            Tela.Dock = (tipo == "cabesario") ? DockStyle.Top : (tipo == "Menu") ? DockStyle.Left : DockStyle.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.voltar = true;
            this.Close();
        }

        public void ExibirUserControl(UserControl novoControl)
    {
        // 1. Limpa todos os controles existentes no painel
        Controls.Clear();
        
        ChamarBase();
        ChamarConsoleUser(novoControl,"mini");
        
        // Opcional: Traz o novo controle para frente, caso haja sobreposição
        novoControl.BringToFront(); 
    }
    }
}
