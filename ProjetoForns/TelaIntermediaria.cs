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
    public partial class TelaIntermediaria : UserControl
    {
        public TelaIntermediaria()
        {
            InitializeComponent();            
        }


        private void BTM_Estoque_Click(object sender, EventArgs e)
        {
            ChamarTelaFuncionario(new MenuEstoque(), "estoque");
        }

        private void BTM_Venda_Click(object sender, EventArgs e)
        {
            ChamarTelaFuncionario(new TelaVenda(), "venda");
        }

        private void ChamarTelaFuncionario( UserControl tela, string tipo)
            {
            Form1 formPai = this.ParentForm as Form1;
           
            if (formPai != null)
            {
                formPai.ChamarMineTela(tela, nivelAcesso: tipo);
            }
        }
    }
}
