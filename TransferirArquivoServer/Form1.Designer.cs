namespace TransferirArquivoServer
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
            this.txtEnderecoIp = new System.Windows.Forms.TextBox();
            this.numPorta = new System.Windows.Forms.NumericUpDown();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.btnPararServidor = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor para Compartilhar Arquivo";
            // 
            // txtEnderecoIp
            // 
            this.txtEnderecoIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIp.Location = new System.Drawing.Point(104, 109);
            this.txtEnderecoIp.Name = "txtEnderecoIp";
            this.txtEnderecoIp.Size = new System.Drawing.Size(295, 35);
            this.txtEnderecoIp.TabIndex = 1;
            this.txtEnderecoIp.Text = "127.0.0.1";
            // 
            // numPorta
            // 
            this.numPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPorta.Location = new System.Drawing.Point(425, 109);
            this.numPorta.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPorta.Name = "numPorta";
            this.numPorta.Size = new System.Drawing.Size(295, 35);
            this.numPorta.TabIndex = 2;
            this.numPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(104, 150);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(295, 46);
            this.btnEstabelecerConexao.TabIndex = 3;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
            // 
            // btnPararServidor
            // 
            this.btnPararServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararServidor.Location = new System.Drawing.Point(425, 150);
            this.btnPararServidor.Name = "btnPararServidor";
            this.btnPararServidor.Size = new System.Drawing.Size(295, 46);
            this.btnPararServidor.TabIndex = 4;
            this.btnPararServidor.Text = "Parar Servidor";
            this.btnPararServidor.UseVisualStyleBackColor = true;
            this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
            // 
            // listLog
            // 
            this.listLog.FormattingEnabled = true;
            this.listLog.Location = new System.Drawing.Point(104, 295);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(616, 147);
            this.listLog.TabIndex = 5;
            // 
            // txtPasta
            // 
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasta.Location = new System.Drawing.Point(104, 225);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(616, 36);
            this.txtPasta.TabIndex = 6;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique e selecione a pasta...";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnPararServidor);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.numPorta);
            this.Controls.Add(this.txtEnderecoIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIp;
        private System.Windows.Forms.NumericUpDown numPorta;
        private System.Windows.Forms.Button btnEstabelecerConexao;
        private System.Windows.Forms.Button btnPararServidor;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.LinkLabel txtPasta;
    }
}

