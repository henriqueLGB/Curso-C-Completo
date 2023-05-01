namespace parte040
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
            folder = new FolderBrowserDialog();
            button1 = new Button();
            lblFolder = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(312, 267);
            button1.Name = "button1";
            button1.Size = new Size(236, 97);
            button1.TabIndex = 0;
            button1.Text = "Pasta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblFolder
            // 
            lblFolder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFolder.Location = new Point(138, 148);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(586, 88);
            lblFolder.TabIndex = 1;
            lblFolder.Text = "Pasta Selecionada";
            lblFolder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFolder);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folder;
        private Button button1;
        private Label lblFolder;
    }
}