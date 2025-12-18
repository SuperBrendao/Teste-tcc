namespace ProjetoForns
{
    partial class MenuEstoque
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTM_VizualizarEstoque = new System.Windows.Forms.Button();
            this.BTM_Cadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTM_VizualizarEstoque
            // 
            this.BTM_VizualizarEstoque.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BTM_VizualizarEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTM_VizualizarEstoque.ImageKey = "(nenhum/a)";
            this.BTM_VizualizarEstoque.Location = new System.Drawing.Point(0, 34);
            this.BTM_VizualizarEstoque.Name = "BTM_VizualizarEstoque";
            this.BTM_VizualizarEstoque.Size = new System.Drawing.Size(150, 23);
            this.BTM_VizualizarEstoque.TabIndex = 0;
            this.BTM_VizualizarEstoque.Text = "Vizualizar";
            this.BTM_VizualizarEstoque.UseVisualStyleBackColor = true;
            this.BTM_VizualizarEstoque.Click += new System.EventHandler(this.BTM_VizualizarEstoque_Click);
            // 
            // BTM_Cadastrar
            // 
            this.BTM_Cadastrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BTM_Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTM_Cadastrar.ImageKey = "(nenhum/a)";
            this.BTM_Cadastrar.Location = new System.Drawing.Point(0, 121);
            this.BTM_Cadastrar.Name = "BTM_Cadastrar";
            this.BTM_Cadastrar.Size = new System.Drawing.Size(150, 23);
            this.BTM_Cadastrar.TabIndex = 3;
            this.BTM_Cadastrar.Text = "Cadastrar";
            this.BTM_Cadastrar.UseVisualStyleBackColor = true;
            this.BTM_Cadastrar.Click += new System.EventHandler(this.BTM_Cadastrar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageKey = "(nenhum/a)";
            this.button1.Location = new System.Drawing.Point(0, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dar Baixa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageKey = "(nenhum/a)";
            this.button2.Location = new System.Drawing.Point(0, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Solicidar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estoque";
            // 
            // MenuEstoque
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTM_Cadastrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTM_VizualizarEstoque);
            this.Name = "MenuEstoque";
            this.Size = new System.Drawing.Size(151, 345);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTM_VizualizarEstoque;
        private System.Windows.Forms.Button BTM_Cadastrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
