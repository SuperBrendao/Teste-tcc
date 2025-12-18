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
            ChamarBase("Principal");
        }

       public static bool BostarLogoParaEstoque = false;

        private void ChamarBase(string nivelAcesso,UserControl controle=null)
        {
            if (nivelAcesso == "Principal")
            {
                ChamarTelaPrincipal();//ou MenuGerente ou TelaDeEscolha
                ChamarConsoleUser(new Cabesario(naoMostar2: "VoltarFuncionario"), "cabesario");
            }
            else 
            {
                
                ChamarTelaFuncionario(nivelAcesso, controle: controle);//ou Vendedor ou Estoque
                ChamarConsoleUser(new Cabesario(), "cabesario");
            }
                
        }



        private void ChamarTelaPrincipal() 
        {
            switch (Program.acessoRegular)//valor é definico no momento do login
            {
                case "1":
                    ChamarConsoleUser(new TelaLogo(), "full");
                    ChamarConsoleUser(new MenuGerente(), "Menu");
                    break;
                case "2":
                case "3":
                    ChamarConsoleUser(new TelaIntermediaria(), "full");
                    break;
            }
        }



        private void ChamarTelaFuncionario(string nivelAcesso, UserControl controle = null) 
        {
            
            if (nivelAcesso == "estoque")
            {
                

                if (controle != null )
                {
                    if (BostarLogoParaEstoque == false) { controle = new TelaLogo(); BostarLogoParaEstoque = true; }
                    
                    ChamarConsoleUser(controle, "full");
                   
                }
               

                
                    ChamarConsoleUser(new MenuEstoque(), "Menu");
               
            }
            else if (nivelAcesso == "venda")
            {
                ChamarConsoleUser(new TelaVenda(), "Full");
            }
        }
      


        private void ChamarConsoleUser(Control Tela,string tipo)
        {
            Controls.Add(Tela);
            Tela.Dock = (tipo == "cabesario") ? DockStyle.Top : (tipo == "Menu") ? DockStyle.Left : DockStyle.Fill;
        }



        public void ExibirUserControl(UserControl novoControl, string nivelAcesso = "")
        {
      
            Controls.Clear();
            ChamarBase((nivelAcesso == "") ?"Principal": nivelAcesso,controle: novoControl);
            if (nivelAcesso == "") { ChamarConsoleUser(novoControl, "mini"); }
            novoControl.BringToFront(); 
        }



        public void ChamarMineTela(UserControl Tela, string nivelAcesso)
        { 
               ExibirUserControl(Tela, nivelAcesso: nivelAcesso);
        }
    }
}
