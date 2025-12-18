namespace ProjetoForns
{
    partial class TelaIntermediaria
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
            this.BTM_Estoque = new System.Windows.Forms.Button();
            this.BTM_Venda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTM_Estoque
            // 
            this.BTM_Estoque.Location = new System.Drawing.Point(213, 197);
            this.BTM_Estoque.Name = "BTM_Estoque";
            this.BTM_Estoque.Size = new System.Drawing.Size(258, 84);
            this.BTM_Estoque.TabIndex = 0;
            this.BTM_Estoque.Text = "Estoque";
            this.BTM_Estoque.UseVisualStyleBackColor = true;
            this.BTM_Estoque.Click += new System.EventHandler(this.BTM_Estoque_Click);
            // 
            // BTM_Venda
            // 
            this.BTM_Venda.Location = new System.Drawing.Point(516, 197);
            this.BTM_Venda.Name = "BTM_Venda";
            this.BTM_Venda.Size = new System.Drawing.Size(258, 84);
            this.BTM_Venda.TabIndex = 1;
            this.BTM_Venda.Text = "Venda";
            this.BTM_Venda.UseVisualStyleBackColor = true;
            this.BTM_Venda.Click += new System.EventHandler(this.BTM_Venda_Click);
            // 
            // TelaIntermediaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTM_Venda);
            this.Controls.Add(this.BTM_Estoque);
            this.Name = "TelaIntermediaria";
            this.Size = new System.Drawing.Size(968, 489);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTM_Estoque;
        private System.Windows.Forms.Button BTM_Venda;
    }
}
