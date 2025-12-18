using System;
using System.Windows.Forms;

namespace ProjetoForns
{
    public partial class MenuGerente : UserControl
    {
        public MenuGerente()
        {
            InitializeComponent();
        }

        private void BTM_CadastroFun_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new CadFuncionario());
        }
        private void BTM_VerSolicitaçoes_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new PermicaoTemp());
        }

        private void BTM_PedidoEstoque_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new VisualizarSolicitacao());
        }

        private void TBM_MovimentacaoFum_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new MovimentacaoFun());
        }


        private void ChamarSubTela(UserControl tela, string tipo="")
        {
            Form1 formPai = this.ParentForm as Form1;

            if (formPai != null)
            {
                formPai.ChamarMineTela(tela, nivelAcesso: tipo);
            }
        } 
    }
}
