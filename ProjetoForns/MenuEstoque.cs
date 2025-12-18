using System;
using System.Windows.Forms;

namespace ProjetoForns
{
    public partial class MenuEstoque : UserControl
    {
        public MenuEstoque()
        {
            InitializeComponent();
        }

        private void BTM_VizualizarEstoque_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new VisualizarEstoque());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new SolicitacaoReposicao());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new DarBaixaEstoque());
        }

        private void BTM_Cadastrar_Click(object sender, EventArgs e)
        {
            ChamarSubTela(new CadastrarProduto());
        }



        private void ChamarSubTela(UserControl tela, string tipo = "estoque")
        {
            Form1 formPai = this.ParentForm as Form1;

            if (formPai != null)
            {
                formPai.ChamarMineTela(tela, nivelAcesso: tipo);
            }
        }
    }
}
