namespace ChatServer
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
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.numericPorta = new System.Windows.Forms.NumericUpDown();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(12, 12);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(417, 35);
            this.txtEndereco.TabIndex = 0;
            this.txtEndereco.Text = "127.0.0.1";
            // 
            // numericPorta
            // 
            this.numericPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPorta.Location = new System.Drawing.Point(435, 12);
            this.numericPorta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPorta.Name = "numericPorta";
            this.numericPorta.Size = new System.Drawing.Size(120, 35);
            this.numericPorta.TabIndex = 1;
            this.numericPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnStartServer
            // 
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartServer.Location = new System.Drawing.Point(579, 12);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(209, 35);
            this.btnStartServer.TabIndex = 2;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(12, 53);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(776, 394);
            this.listLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.numericPorta);
            this.Controls.Add(this.txtEndereco);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.NumericUpDown numericPorta;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.ListBox listLog;
    }
}

