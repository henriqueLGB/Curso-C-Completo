namespace LerEscrever
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEscrever = new Button();
            btnLer = new Button();
            txtConteudo = new RichTextBox();
            btnLerBinario = new Button();
            btnEscreverBinario = new Button();
            SuspendLayout();
            // 
            // btnEscrever
            // 
            btnEscrever.Location = new Point(12, 332);
            btnEscrever.Name = "btnEscrever";
            btnEscrever.Size = new Size(171, 72);
            btnEscrever.TabIndex = 1;
            btnEscrever.Text = "Escrever TXT";
            btnEscrever.UseVisualStyleBackColor = true;
            btnEscrever.Click += btnEscrever_Click;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(189, 332);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(171, 72);
            btnLer.TabIndex = 2;
            btnLer.Text = "Ler TXT";
            btnLer.UseVisualStyleBackColor = true;
            btnLer.Click += btnLer_Click;
            // 
            // txtConteudo
            // 
            txtConteudo.Location = new Point(11, 12);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(777, 314);
            txtConteudo.TabIndex = 3;
            txtConteudo.Text = "";
            // 
            // btnLerBinario
            // 
            btnLerBinario.Location = new Point(543, 332);
            btnLerBinario.Name = "btnLerBinario";
            btnLerBinario.Size = new Size(171, 72);
            btnLerBinario.TabIndex = 4;
            btnLerBinario.Text = "Ler Binário";
            btnLerBinario.UseVisualStyleBackColor = true;
            btnLerBinario.Click += btnLerBinario_Click;
            // 
            // btnEscreverBinario
            // 
            btnEscreverBinario.Location = new Point(366, 332);
            btnEscreverBinario.Name = "btnEscreverBinario";
            btnEscreverBinario.Size = new Size(171, 72);
            btnEscreverBinario.TabIndex = 5;
            btnEscreverBinario.Text = "Escrever Binário";
            btnEscreverBinario.UseVisualStyleBackColor = true;
            btnEscreverBinario.Click += btnEscreverBinario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEscreverBinario);
            Controls.Add(btnLerBinario);
            Controls.Add(txtConteudo);
            Controls.Add(btnLer);
            Controls.Add(btnEscrever);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnEscrever;
        private Button btnLer;
        private RichTextBox txtConteudo;
        private Button btnLerBinario;
        private Button btnEscreverBinario;
    }
}