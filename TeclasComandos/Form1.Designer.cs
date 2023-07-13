namespace TeclasComandos
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnTeclaX = new System.Windows.Forms.Button();
            this.btnTeclaEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(12, 9);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(776, 95);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Digite uma tecla..";
            // 
            // btnTeclaX
            // 
            this.btnTeclaX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaX.Location = new System.Drawing.Point(17, 368);
            this.btnTeclaX.Name = "btnTeclaX";
            this.btnTeclaX.Size = new System.Drawing.Size(181, 57);
            this.btnTeclaX.TabIndex = 1;
            this.btnTeclaX.Text = "Tecla X";
            this.btnTeclaX.UseVisualStyleBackColor = true;
            this.btnTeclaX.Click += new System.EventHandler(this.btnTeclaX_Click);
            this.btnTeclaX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // btnTeclaEnter
            // 
            this.btnTeclaEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeclaEnter.Location = new System.Drawing.Point(607, 368);
            this.btnTeclaEnter.Name = "btnTeclaEnter";
            this.btnTeclaEnter.Size = new System.Drawing.Size(181, 57);
            this.btnTeclaEnter.TabIndex = 2;
            this.btnTeclaEnter.Text = "Tecla Enter";
            this.btnTeclaEnter.UseVisualStyleBackColor = true;
            this.btnTeclaEnter.Click += new System.EventHandler(this.btnTeclaEnter_Click);
            this.btnTeclaEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeclaEnter);
            this.Controls.Add(this.btnTeclaX);
            this.Controls.Add(this.lbResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnTeclaX;
        private System.Windows.Forms.Button btnTeclaEnter;
    }
}

