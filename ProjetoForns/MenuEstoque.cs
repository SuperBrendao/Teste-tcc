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
    public partial class MenuEstoque : UserControl
    {
        public MenuEstoque()
        {
            InitializeComponent();
        }






        private void ChamarMineTela(UserControl Tela)
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
