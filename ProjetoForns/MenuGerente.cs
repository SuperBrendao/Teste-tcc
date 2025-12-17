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
            ChamarMineTela(new CadFuncionario());
        }
        private void BTM_VerSolicitaçoes_Click(object sender, EventArgs e)
        {
            ChamarMineTela(new PermicaoTemp());
        }

        private void BTM_PedidoEstoque_Click(object sender, EventArgs e)
        {
            ChamarMineTela(new VisualizarSolicitacao());
        }

        private void TBM_MovimentacaoFum_Click(object sender, EventArgs e)
        {
            ChamarMineTela(new MovimentacaoFun());
        }






        private void ChamarMineTela(UserControl Tela ) 
        {
            // 1. Garante que o ParentForm existe
            if (this.ParentForm != null)
            {
                // 2. Cria uma instância do novo UserControl que você quer exibir
                UserControl novoConteudo = Tela; // Substitua pelo nome do seu novo UserControl

                // 3. Converte o ParentForm para o tipo FormPrincipal (seu Form personalizado)
                Form1 formPai = this.ParentForm as Form1;

                // 4. Chama o método no FormPrincipal para fazer a troca
                if (formPai != null)
                {
                    formPai.ExibirUserControl(novoConteudo);
                }
            }
        }

       
    }
}
