namespace CriptoFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCriptografarArq = new System.Windows.Forms.Button();
            this.btnDescriptografarArq = new System.Windows.Forms.Button();
            this.btnCriarChaves = new System.Windows.Forms.Button();
            this.btnExportarChavePub = new System.Windows.Forms.Button();
            this.btnImportarChavePub = new System.Windows.Forms.Button();
            this.btnObterChavePrivada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chave não definida";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(259, 177);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 38);
            this.txtSearch.TabIndex = 1;
            // 
            // btnCriptografarArq
            // 
            this.btnCriptografarArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografarArq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriptografarArq.Location = new System.Drawing.Point(12, 307);
            this.btnCriptografarArq.Name = "btnCriptografarArq";
            this.btnCriptografarArq.Size = new System.Drawing.Size(252, 57);
            this.btnCriptografarArq.TabIndex = 2;
            this.btnCriptografarArq.Text = "Criptografar Arquivo";
            this.btnCriptografarArq.UseVisualStyleBackColor = true;
            this.btnCriptografarArq.Click += new System.EventHandler(this.btnCriptografarArq_Click);
            // 
            // btnDescriptografarArq
            // 
            this.btnDescriptografarArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescriptografarArq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescriptografarArq.Location = new System.Drawing.Point(270, 307);
            this.btnDescriptografarArq.Name = "btnDescriptografarArq";
            this.btnDescriptografarArq.Size = new System.Drawing.Size(249, 57);
            this.btnDescriptografarArq.TabIndex = 3;
            this.btnDescriptografarArq.Text = "Descriptografar Arquivo";
            this.btnDescriptografarArq.UseVisualStyleBackColor = true;
            this.btnDescriptografarArq.Click += new System.EventHandler(this.btnDescriptografarArq_Click);
            // 
            // btnCriarChaves
            // 
            this.btnCriarChaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarChaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarChaves.Location = new System.Drawing.Point(525, 307);
            this.btnCriarChaves.Name = "btnCriarChaves";
            this.btnCriarChaves.Size = new System.Drawing.Size(236, 57);
            this.btnCriarChaves.TabIndex = 4;
            this.btnCriarChaves.Text = "Criar Chaves";
            this.btnCriarChaves.UseVisualStyleBackColor = true;
            this.btnCriarChaves.Click += new System.EventHandler(this.btnCriarChaves_Click);
            // 
            // btnExportarChavePub
            // 
            this.btnExportarChavePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarChavePub.Location = new System.Drawing.Point(12, 381);
            this.btnExportarChavePub.Name = "btnExportarChavePub";
            this.btnExportarChavePub.Size = new System.Drawing.Size(252, 57);
            this.btnExportarChavePub.TabIndex = 5;
            this.btnExportarChavePub.Text = "Exportar Chave Público";
            this.btnExportarChavePub.UseVisualStyleBackColor = true;
            this.btnExportarChavePub.Click += new System.EventHandler(this.btnExportarChavePub_Click);
            // 
            // btnImportarChavePub
            // 
            this.btnImportarChavePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportarChavePub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportarChavePub.Location = new System.Drawing.Point(270, 381);
            this.btnImportarChavePub.Name = "btnImportarChavePub";
            this.btnImportarChavePub.Size = new System.Drawing.Size(249, 57);
            this.btnImportarChavePub.TabIndex = 6;
            this.btnImportarChavePub.Text = "Importar Chave Pública";
            this.btnImportarChavePub.UseVisualStyleBackColor = true;
            this.btnImportarChavePub.Click += new System.EventHandler(this.btnImportarChavePub_Click);
            // 
            // btnObterChavePrivada
            // 
            this.btnObterChavePrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterChavePrivada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObterChavePrivada.Location = new System.Drawing.Point(525, 381);
            this.btnObterChavePrivada.Name = "btnObterChavePrivada";
            this.btnObterChavePrivada.Size = new System.Drawing.Size(236, 57);
            this.btnObterChavePrivada.TabIndex = 7;
            this.btnObterChavePrivada.Text = "Obter Chave Privada";
            this.btnObterChavePrivada.UseVisualStyleBackColor = true;
            this.btnObterChavePrivada.Click += new System.EventHandler(this.btnObterChavePrivada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterChavePrivada);
            this.Controls.Add(this.btnImportarChavePub);
            this.Controls.Add(this.btnExportarChavePub);
            this.Controls.Add(this.btnCriarChaves);
            this.Controls.Add(this.btnDescriptografarArq);
            this.Controls.Add(this.btnCriptografarArq);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCriptografarArq;
        private System.Windows.Forms.Button btnDescriptografarArq;
        private System.Windows.Forms.Button btnCriarChaves;
        private System.Windows.Forms.Button btnExportarChavePub;
        private System.Windows.Forms.Button btnImportarChavePub;
        private System.Windows.Forms.Button btnObterChavePrivada;
    }
}

