﻿namespace parte017
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
            txt = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Location = new Point(12, 12);
            txt.Name = "txt";
            txt.Size = new Size(776, 286);
            txt.TabIndex = 0;
            txt.Text = "Digite Algo...";
            txt.TextChanged += txt_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 315);
            button1.Name = "button1";
            button1.Size = new Size(151, 78);
            button1.TabIndex = 1;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(637, 315);
            button2.Name = "button2";
            button2.Size = new Size(151, 78);
            button2.TabIndex = 2;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txt;
        private Button button1;
        private Button button2;
    }
}