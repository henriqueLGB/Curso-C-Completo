namespace parte036
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
            printDocument = new System.Drawing.Printing.PrintDocument();
            richText = new RichTextBox();
            button1 = new Button();
            printDialog1 = new PrintDialog();
            button2 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            SuspendLayout();
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // richText
            // 
            richText.Location = new Point(127, 49);
            richText.Name = "richText";
            richText.Size = new Size(548, 248);
            richText.TabIndex = 0;
            richText.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(127, 336);
            button1.Name = "button1";
            button1.Size = new Size(264, 102);
            button1.TabIndex = 1;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument;
            printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(397, 336);
            button2.Name = "button2";
            button2.Size = new Size(278, 102);
            button2.TabIndex = 2;
            button2.Text = "Imprimir 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private RichTextBox richText;
        private Button button1;
        private PrintDialog printDialog1;
        private Button button2;
        private PageSetupDialog pageSetupDialog1;
    }
}