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
    public partial class TelaLogo : UserControl
    {
        public TelaLogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formPai = this.ParentForm as Form1;

            if (formPai != null)
            {
                formPai.ChamarMineTela(new VisualizarEstoque(), nivelAcesso: "");
            }
        }
    }
}
