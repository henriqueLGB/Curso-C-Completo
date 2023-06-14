namespace TransferenciaArquivoCliente
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.numericPorta = new System.Windows.Forms.NumericUpDown();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbArquivo = new System.Windows.Forms.LinkLabel();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente para Compartilhar Arquivo";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(110, 108);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(439, 35);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.Text = "127.0.0.1";
            // 
            // numericPorta
            // 
            this.numericPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPorta.Location = new System.Drawing.Point(555, 108);
            this.numericPorta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPorta.Name = "numericPorta";
            this.numericPorta.Size = new System.Drawing.Size(120, 35);
            this.numericPorta.TabIndex = 2;
            this.numericPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(110, 337);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(565, 101);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Arquivo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbArquivo
            // 
            this.lbArquivo.AutoSize = true;
            this.lbArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArquivo.Location = new System.Drawing.Point(194, 182);
            this.lbArquivo.Name = "lbArquivo";
            this.lbArquivo.Size = new System.Drawing.Size(397, 29);
            this.lbArquivo.TabIndex = 4;
            this.lbArquivo.TabStop = true;
            this.lbArquivo.Text = "Clique para selecionar um arquivo...";
            this.lbArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbArquivo_LinkClicked);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbStatus.Location = new System.Drawing.Point(338, 258);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(108, 37);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbArquivo);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.numericPorta);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.NumericUpDown numericPorta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.LinkLabel lbArquivo;
        private System.Windows.Forms.Label lbStatus;
    }
}

