namespace parte039
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
            colorDialog = new ColorDialog();
            lblColor = new Label();
            btnCor = new Button();
            SuspendLayout();
            // 
            // lblColor
            // 
            lblColor.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.Location = new Point(84, 53);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(653, 173);
            lblColor.TabIndex = 0;
            lblColor.Text = "Selecione a Cor";
            lblColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCor
            // 
            btnCor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCor.Location = new Point(292, 229);
            btnCor.Name = "btnCor";
            btnCor.Size = new Size(218, 102);
            btnCor.TabIndex = 1;
            btnCor.Text = "Cor";
            btnCor.UseVisualStyleBackColor = true;
            btnCor.Click += btnCor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCor);
            Controls.Add(lblColor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog;
        private Label lblColor;
        private Button btnCor;
    }
}