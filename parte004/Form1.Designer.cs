namespace parte004
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
            lista = new ListBox();
            button1 = new Button();
            txtNome = new TextBox();
            btnLimpar = new Button();
            btnRemover = new Button();
            btnRemoverIndice = new Button();
            btnQuantidadesItens = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.BackColor = SystemColors.GradientInactiveCaption;
            lista.BorderStyle = BorderStyle.FixedSingle;
            lista.Dock = DockStyle.Right;
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(317, 0);
            lista.Name = "lista";
            lista.Size = new Size(483, 450);
            lista.TabIndex = 0;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(42, 57);
            button1.Name = "button1";
            button1.Size = new Size(233, 44);
            button1.TabIndex = 1;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(42, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(233, 23);
            txtNome.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(42, 107);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(233, 45);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(42, 158);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(233, 45);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnRemoverIndice
            // 
            btnRemoverIndice.Location = new Point(42, 209);
            btnRemoverIndice.Name = "btnRemoverIndice";
            btnRemoverIndice.Size = new Size(233, 45);
            btnRemoverIndice.TabIndex = 5;
            btnRemoverIndice.Text = "Remover item do índice";
            btnRemoverIndice.UseVisualStyleBackColor = true;
            btnRemoverIndice.Click += btnRemoverIndice_Click;
            // 
            // btnQuantidadesItens
            // 
            btnQuantidadesItens.Location = new Point(42, 260);
            btnQuantidadesItens.Name = "btnQuantidadesItens";
            btnQuantidadesItens.Size = new Size(233, 45);
            btnQuantidadesItens.TabIndex = 6;
            btnQuantidadesItens.Text = "Quantidade de itens";
            btnQuantidadesItens.UseVisualStyleBackColor = true;
            btnQuantidadesItens.Click += btnQuantidadesItens_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuantidadesItens);
            Controls.Add(btnRemoverIndice);
            Controls.Add(btnRemover);
            Controls.Add(btnLimpar);
            Controls.Add(txtNome);
            Controls.Add(button1);
            Controls.Add(lista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista;
        private Button button1;
        private TextBox txtNome;
        private Button btnLimpar;
        private Button btnRemover;
        private Button btnRemoverIndice;
        private Button btnQuantidadesItens;
    }
}