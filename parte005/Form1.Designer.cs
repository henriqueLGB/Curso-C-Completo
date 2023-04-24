namespace parte005
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
            check01 = new CheckBox();
            check02 = new CheckBox();
            check03 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // check01
            // 
            check01.BackColor = SystemColors.ControlLight;
            check01.CheckAlign = ContentAlignment.MiddleRight;
            check01.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            check01.ForeColor = Color.IndianRed;
            check01.Location = new Point(12, 12);
            check01.Name = "check01";
            check01.Size = new Size(199, 27);
            check01.TabIndex = 0;
            check01.Text = "Opção 1";
            check01.UseVisualStyleBackColor = false;
            check01.CheckedChanged += check01_CheckedChanged;
            // 
            // check02
            // 
            check02.BackColor = SystemColors.ControlLight;
            check02.CheckAlign = ContentAlignment.MiddleRight;
            check02.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            check02.ForeColor = Color.IndianRed;
            check02.Location = new Point(12, 45);
            check02.Name = "check02";
            check02.Size = new Size(199, 27);
            check02.TabIndex = 1;
            check02.Text = "Opção 2";
            check02.UseVisualStyleBackColor = false;
            check02.CheckedChanged += check02_CheckedChanged;
            // 
            // check03
            // 
            check03.BackColor = SystemColors.ControlLight;
            check03.CheckAlign = ContentAlignment.MiddleRight;
            check03.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            check03.ForeColor = Color.IndianRed;
            check03.Location = new Point(12, 78);
            check03.Name = "check03";
            check03.Size = new Size(199, 27);
            check03.TabIndex = 2;
            check03.Text = "Opção 3";
            check03.UseVisualStyleBackColor = false;
            check03.CheckedChanged += check03_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 121);
            button1.Name = "button1";
            button1.Size = new Size(199, 54);
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
            Controls.Add(check03);
            Controls.Add(check02);
            Controls.Add(check01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private CheckBox check01;
        private CheckBox check02;
        private CheckBox check03;
        private Button button1;
    }
}