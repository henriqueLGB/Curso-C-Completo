namespace ChatCliente
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(12, 12);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(314, 35);
            this.txtEndereco.TabIndex = 0;
            this.txtEndereco.Text = "127.0.0.1";
            // 
            // numericPorta
            // 
            this.numericPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPorta.Location = new System.Drawing.Point(332, 12);
            this.numericPorta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPorta.Name = "numericPorta";
            this.numericPorta.Size = new System.Drawing.Size(170, 35);
            this.numericPorta.TabIndex = 1;
            this.numericPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(12, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(314, 35);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Visitante";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnConectar.Location = new System.Drawing.Point(332, 53);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(170, 35);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 95);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(489, 284);
            this.txtLog.TabIndex = 4;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Enabled = false;
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(13, 385);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(373, 35);
            this.txtMensagem.TabIndex = 5;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Enabled = false;
            this.btnEnviarMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMensagem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEnviarMensagem.Location = new System.Drawing.Point(392, 385);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(110, 35);
            this.btnEnviarMensagem.TabIndex = 6;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbStatus.Location = new System.Drawing.Point(170, 442);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(181, 29);
            this.lbStatus.TabIndex = 7;
            this.lbStatus.Text = "Não Conectado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 507);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtUsuario);
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.Label lbStatus;
    }
}

