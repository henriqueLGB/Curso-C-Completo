namespace parte008
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
            dateTime = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTime
            // 
            dateTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.Location = new Point(12, 12);
            dateTime.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dateTime.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(165, 35);
            dateTime.TabIndex = 0;
            dateTime.Value = new DateTime(2023, 4, 24, 8, 51, 42, 0);
            dateTime.ValueChanged += dateTime_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(207, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 35);
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
            Controls.Add(dateTime);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTime;
        private Button button1;
    }
}