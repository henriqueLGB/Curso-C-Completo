namespace parte042
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
            openFileDialog1 = new OpenFileDialog();
            lblTexto = new Label();
            button1 = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecione um arquivo";
            // 
            // lblTexto
            // 
            lblTexto.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.Location = new Point(54, 9);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(717, 115);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Arquivo";
            lblTexto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(315, 351);
            button1.Name = "button1";
            button1.Size = new Size(232, 87);
            button1.TabIndex = 1;
            button1.Text = "Abrir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(54, 147);
            listBox.Name = "listBox";
            listBox.Size = new Size(717, 184);
            listBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(button1);
            Controls.Add(lblTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label lblTexto;
        private Button button1;
        private ListBox listBox;
    }
}