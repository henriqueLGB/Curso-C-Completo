namespace ControleDeErros
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
            lblText = new Label();
            btnExecutar = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblText.Location = new Point(181, 105);
            lblText.Name = "lblText";
            lblText.Size = new Size(486, 136);
            lblText.TabIndex = 0;
            lblText.Text = "label1";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExecutar
            // 
            btnExecutar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExecutar.Location = new Point(313, 244);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(218, 88);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExecutar);
            Controls.Add(lblText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblText;
        private Button btnExecutar;
    }
}