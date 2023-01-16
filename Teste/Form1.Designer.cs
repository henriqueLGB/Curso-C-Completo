namespace Teste
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Teste = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Teste
            // 
            this.Teste.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teste.Location = new System.Drawing.Point(251, 202);
            this.Teste.Name = "Teste";
            this.Teste.Size = new System.Drawing.Size(293, 80);
            this.Teste.TabIndex = 0;
            this.Teste.Text = "Executar";
            this.Teste.UseVisualStyleBackColor = false;
            this.Teste.Click += new System.EventHandler(this.Teste_Click);
            this.Teste.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.Teste.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(244, 141);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(309, 37);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Título da Aplicação";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.Teste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Teste;
        private System.Windows.Forms.Label lbTitulo;
    }
}

