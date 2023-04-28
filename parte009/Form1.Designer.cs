namespace parte009
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
            link = new LinkLabel();
            SuspendLayout();
            // 
            // link
            // 
            link.AutoSize = true;
            link.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            link.LinkBehavior = LinkBehavior.NeverUnderline;
            link.LinkColor = Color.Black;
            link.Location = new Point(12, 9);
            link.Name = "link";
            link.Size = new Size(143, 32);
            link.TabIndex = 0;
            link.TabStop = true;
            link.Text = "Clique aqui";
            link.LinkClicked += link_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(link);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel link;
    }
}