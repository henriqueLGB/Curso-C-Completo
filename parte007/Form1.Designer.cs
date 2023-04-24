namespace parte007
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
            combo = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // combo
            // 
            combo.BackColor = SystemColors.InactiveCaption;
            combo.Dock = DockStyle.Top;
            combo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            combo.FormattingEnabled = true;
            combo.Location = new Point(0, 0);
            combo.Name = "combo";
            combo.Size = new Size(800, 38);
            combo.TabIndex = 0;
            combo.Text = "--Selecione um item--";
            combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 63);
            button1.Name = "button1";
            button1.Size = new Size(161, 61);
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
            Controls.Add(combo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox combo;
        private Button button1;
    }
}