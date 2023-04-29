namespace parte020
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtPesquisa = new TextBox();
            btnAcessar = new Button();
            btnBack = new Button();
            btnGoForward = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 49);
            webView21.Name = "webView21";
            webView21.Size = new Size(786, 389);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(177, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(531, 39);
            txtPesquisa.TabIndex = 1;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(714, 4);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(84, 39);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Go";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(77, 39);
            btnBack.TabIndex = 3;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnGoForward
            // 
            btnGoForward.Location = new Point(95, 4);
            btnGoForward.Name = "btnGoForward";
            btnGoForward.Size = new Size(75, 39);
            btnGoForward.TabIndex = 4;
            btnGoForward.Text = ">";
            btnGoForward.UseVisualStyleBackColor = true;
            btnGoForward.Click += btnGoForward_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoForward);
            Controls.Add(btnBack);
            Controls.Add(btnAcessar);
            Controls.Add(txtPesquisa);
            Controls.Add(webView21);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txtPesquisa;
        private Button btnAcessar;
        private Button btnBack;
        private Button btnGoForward;
    }
}