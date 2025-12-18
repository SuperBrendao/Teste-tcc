namespace ProjetoForns
{
    partial class Cabesario
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
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Maximisar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.PictureBox();
            this.VoltarFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackColor = System.Drawing.Color.Red;
            this.Fechar.Location = new System.Drawing.Point(510, 0);
            this.Fechar.Margin = new System.Windows.Forms.Padding(2);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(34, 37);
            this.Fechar.TabIndex = 0;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Maximisar
            // 
            this.Maximisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximisar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Maximisar.Location = new System.Drawing.Point(472, 0);
            this.Maximisar.Margin = new System.Windows.Forms.Padding(2);
            this.Maximisar.Name = "Maximisar";
            this.Maximisar.Size = new System.Drawing.Size(34, 37);
            this.Maximisar.TabIndex = 1;
            this.Maximisar.TabStop = false;
            this.Maximisar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Minimizar.Location = new System.Drawing.Point(434, 0);
            this.Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 37);
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projeto";
            // 
            // Voltar
            // 
            this.Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Voltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Voltar.Location = new System.Drawing.Point(396, 0);
            this.Voltar.Margin = new System.Windows.Forms.Padding(2);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(34, 37);
            this.Voltar.TabIndex = 4;
            this.Voltar.TabStop = false;
            this.Voltar.DoubleClick += new System.EventHandler(this.VoltarLLogin_DoubleClick);
            // 
            // VoltarFuncionario
            // 
            this.VoltarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoltarFuncionario.BackColor = System.Drawing.SystemColors.ControlText;
            this.VoltarFuncionario.Location = new System.Drawing.Point(358, 0);
            this.VoltarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.VoltarFuncionario.Name = "VoltarFuncionario";
            this.VoltarFuncionario.Size = new System.Drawing.Size(34, 37);
            this.VoltarFuncionario.TabIndex = 5;
            this.VoltarFuncionario.TabStop = false;
            this.VoltarFuncionario.Click += new System.EventHandler(this.VoltarFuncionario_Click);
            this.VoltarFuncionario.DoubleClick += new System.EventHandler(this.VoltarFuncionario_DoubleClick);
            // 
            // Cabesario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.VoltarFuncionario);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Maximisar);
            this.Controls.Add(this.Fechar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cabesario";
            this.Size = new System.Drawing.Size(544, 37);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Cabesario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoltarFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox Maximisar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Voltar;
        private System.Windows.Forms.PictureBox VoltarFuncionario;
    }
}
