namespace parte006
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
            checkList = new CheckedListBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkList
            // 
            checkList.Cursor = Cursors.Hand;
            checkList.Dock = DockStyle.Left;
            checkList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkList.FormattingEnabled = true;
            checkList.Location = new Point(0, 0);
            checkList.Name = "checkList";
            checkList.Size = new Size(352, 450);
            checkList.TabIndex = 0;
            checkList.SelectedIndexChanged += checkList_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(358, 12);
            button1.Name = "button1";
            button1.Size = new Size(430, 71);
            button1.TabIndex = 1;
            button1.Text = "Executar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(358, 86);
            label1.Name = "label1";
            label1.Size = new Size(120, 47);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkList;
        private Button button1;
        private Label label1;
    }
}