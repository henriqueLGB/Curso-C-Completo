namespace parte010
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
            lista = new ListView();
            ID = new ColumnHeader();
            Nome = new ColumnHeader();
            CPF = new ColumnHeader();
            RG = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Columns.AddRange(new ColumnHeader[] { ID, Nome, CPF, RG });
            lista.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lista.FullRowSelect = true;
            lista.GridLines = true;
            lista.LabelEdit = true;
            lista.Location = new Point(12, 30);
            lista.Name = "lista";
            lista.Size = new Size(776, 335);
            lista.TabIndex = 0;
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = View.Details;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "Código";
            ID.Width = 120;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 140;
            // 
            // CPF
            // 
            CPF.Text = "CPF";
            CPF.Width = 100;
            // 
            // RG
            // 
            RG.Text = "RG";
            RG.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(588, 371);
            button1.Name = "button1";
            button1.Size = new Size(200, 68);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lista);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView lista;
        private ColumnHeader ID;
        private ColumnHeader Nome;
        private ColumnHeader CPF;
        private ColumnHeader RG;
        private Button button1;
    }
}