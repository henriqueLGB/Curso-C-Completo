namespace parte016
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
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            radio3 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            radio1.Location = new Point(306, 64);
            radio1.Name = "radio1";
            radio1.Size = new Size(193, 36);
            radio1.TabIndex = 0;
            radio1.Text = "Radio Botão 1";
            radio1.UseVisualStyleBackColor = true;
            radio1.CheckedChanged += radio1_CheckedChanged;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            radio2.Location = new Point(306, 125);
            radio2.Name = "radio2";
            radio2.Size = new Size(193, 36);
            radio2.TabIndex = 1;
            radio2.Text = "Radio Botão 2";
            radio2.UseVisualStyleBackColor = true;
            radio2.CheckedChanged += radio2_CheckedChanged;
            // 
            // radio3
            // 
            radio3.AutoSize = true;
            radio3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            radio3.Location = new Point(306, 192);
            radio3.Name = "radio3";
            radio3.Size = new Size(193, 36);
            radio3.TabIndex = 2;
            radio3.Text = "Radio Botão 3";
            radio3.UseVisualStyleBackColor = true;
            radio3.CheckedChanged += radio3_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(306, 271);
            button1.Name = "button1";
            button1.Size = new Size(193, 54);
            button1.TabIndex = 3;
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
            Controls.Add(radio3);
            Controls.Add(radio2);
            Controls.Add(radio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radio1;
        private RadioButton radio2;
        private RadioButton radio3;
        private Button button1;
    }
}