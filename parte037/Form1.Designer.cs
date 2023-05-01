namespace parte037
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
            printReview = new PrintPreviewControl();
            txtPrint = new RichTextBox();
            btnVisualizar = new Button();
            btnImprir = new Button();
            printDocument = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // printReview
            // 
            printReview.Location = new Point(403, 12);
            printReview.Name = "printReview";
            printReview.Size = new Size(385, 331);
            printReview.TabIndex = 0;
            // 
            // txtPrint
            // 
            txtPrint.Location = new Point(12, 12);
            txtPrint.Name = "txtPrint";
            txtPrint.Size = new Size(374, 331);
            txtPrint.TabIndex = 1;
            txtPrint.Text = "";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizar.Location = new Point(12, 359);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(139, 59);
            btnVisualizar.TabIndex = 2;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnImprir
            // 
            btnImprir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprir.Location = new Point(157, 359);
            btnImprir.Name = "btnImprir";
            btnImprir.Size = new Size(139, 59);
            btnImprir.TabIndex = 3;
            btnImprir.Text = "Imprimir";
            btnImprir.UseVisualStyleBackColor = true;
            btnImprir.Click += btnImprir_Click;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImprir);
            Controls.Add(btnVisualizar);
            Controls.Add(txtPrint);
            Controls.Add(printReview);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private PrintPreviewControl printReview;
        private RichTextBox txtPrint;
        private Button btnVisualizar;
        private Button btnImprir;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}