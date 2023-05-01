namespace parte041
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
            font = new FontDialog();
            lblFont = new Label();
            SuspendLayout();
            // 
            // font
            // 
            font.ShowApply = true;
            font.ShowColor = true;
            font.Apply += font_Apply;
            // 
            // lblFont
            // 
            lblFont.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFont.Location = new Point(124, 87);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(606, 132);
            lblFont.TabIndex = 0;
            lblFont.Text = "Clique e selecione uma fonte";
            lblFont.TextAlign = ContentAlignment.MiddleCenter;
            lblFont.Click += lblFont_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFont);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private FontDialog font;
        private Label lblFont;
    }
}