namespace ProjetoForns
{
    partial class MenuGerente
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTM_CadastroFun = new System.Windows.Forms.Button();
            this.BTM_VerSolicitaçoes = new System.Windows.Forms.Button();
            this.Funcionario = new System.Windows.Forms.Label();
            this.BTM_PedidoEstoque = new System.Windows.Forms.Button();
            this.TBM_MovimentacaoFum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTM_CadastroFun
            // 
            this.BTM_CadastroFun.Location = new System.Drawing.Point(0, 29);
            this.BTM_CadastroFun.Name = "BTM_CadastroFun";
            this.BTM_CadastroFun.Size = new System.Drawing.Size(150, 23);
            this.BTM_CadastroFun.TabIndex = 0;
            this.BTM_CadastroFun.Text = "Cadastro/Atualizar/Deletar";
            this.BTM_CadastroFun.UseVisualStyleBackColor = true;
            this.BTM_CadastroFun.Click += new System.EventHandler(this.BTM_CadastroFun_Click);
            // 
            // BTM_VerSolicitaçoes
            // 
            this.BTM_VerSolicitaçoes.Location = new System.Drawing.Point(0, 58);
            this.BTM_VerSolicitaçoes.Name = "BTM_VerSolicitaçoes";
            this.BTM_VerSolicitaçoes.Size = new System.Drawing.Size(150, 23);
            this.BTM_VerSolicitaçoes.TabIndex = 1;
            this.BTM_VerSolicitaçoes.Text = "Solicitação acesso temp";
            this.BTM_VerSolicitaçoes.UseVisualStyleBackColor = true;
            this.BTM_VerSolicitaçoes.Click += new System.EventHandler(this.BTM_VerSolicitaçoes_Click);
            // 
            // Funcionario
            // 
            this.Funcionario.AutoSize = true;
            this.Funcionario.Location = new System.Drawing.Point(3, 13);
            this.Funcionario.Name = "Funcionario";
            this.Funcionario.Size = new System.Drawing.Size(62, 13);
            this.Funcionario.TabIndex = 2;
            this.Funcionario.Text = "Funcionario";
            // 
            // BTM_PedidoEstoque
            // 
            this.BTM_PedidoEstoque.Location = new System.Drawing.Point(0, 87);
            this.BTM_PedidoEstoque.Name = "BTM_PedidoEstoque";
            this.BTM_PedidoEstoque.Size = new System.Drawing.Size(150, 23);
            this.BTM_PedidoEstoque.TabIndex = 3;
            this.BTM_PedidoEstoque.Text = "Solicidatação de reposição";
            this.BTM_PedidoEstoque.UseVisualStyleBackColor = true;
            this.BTM_PedidoEstoque.Click += new System.EventHandler(this.BTM_PedidoEstoque_Click);
            // 
            // TBM_MovimentacaoFum
            // 
            this.TBM_MovimentacaoFum.Location = new System.Drawing.Point(0, 116);
            this.TBM_MovimentacaoFum.Name = "TBM_MovimentacaoFum";
            this.TBM_MovimentacaoFum.Size = new System.Drawing.Size(150, 23);
            this.TBM_MovimentacaoFum.TabIndex = 5;
            this.TBM_MovimentacaoFum.Text = "Ver Movimentações";
            this.TBM_MovimentacaoFum.UseVisualStyleBackColor = true;
            this.TBM_MovimentacaoFum.Click += new System.EventHandler(this.TBM_MovimentacaoFum_Click);
            // 
            // MenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.TBM_MovimentacaoFum);
            this.Controls.Add(this.BTM_PedidoEstoque);
            this.Controls.Add(this.Funcionario);
            this.Controls.Add(this.BTM_VerSolicitaçoes);
            this.Controls.Add(this.BTM_CadastroFun);
            this.Name = "MenuGerente";
            this.Size = new System.Drawing.Size(150, 331);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTM_CadastroFun;
        private System.Windows.Forms.Button BTM_VerSolicitaçoes;
        private System.Windows.Forms.Label Funcionario;
        private System.Windows.Forms.Button BTM_PedidoEstoque;
        private System.Windows.Forms.Button TBM_MovimentacaoFum;
    }
}
