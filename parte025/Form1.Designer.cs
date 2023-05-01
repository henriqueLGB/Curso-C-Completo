namespace parte025
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtPesquisa1 = new TextBox();
            btn1 = new Button();
            tabPage2 = new TabPage();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtPesquisa2 = new TextBox();
            btn2 = new Button();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 449);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(webView21);
            tabPage1.Controls.Add(txtPesquisa1);
            tabPage1.Controls.Add(btn1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 421);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Browser 1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(3, 36);
            webView21.Name = "webView21";
            webView21.Size = new Size(781, 378);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            // 
            // txtPesquisa1
            // 
            txtPesquisa1.Location = new Point(3, 7);
            txtPesquisa1.Name = "txtPesquisa1";
            txtPesquisa1.Size = new Size(700, 23);
            txtPesquisa1.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(709, 6);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 24);
            btn1.TabIndex = 0;
            btn1.Text = "Ir";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(webView22);
            tabPage2.Controls.Add(txtPesquisa2);
            tabPage2.Controls.Add(btn2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 421);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Browser 2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Location = new Point(3, 36);
            webView22.Name = "webView22";
            webView22.Size = new Size(781, 378);
            webView22.TabIndex = 2;
            webView22.ZoomFactor = 1D;
            // 
            // txtPesquisa2
            // 
            txtPesquisa2.Location = new Point(3, 7);
            txtPesquisa2.Name = "txtPesquisa2";
            txtPesquisa2.Size = new Size(700, 23);
            txtPesquisa2.TabIndex = 1;
            // 
            // btn2
            // 
            btn2.Location = new Point(709, 6);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 24);
            btn2.TabIndex = 0;
            btn2.Text = "Ir";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "Form1";
            Text = "Form1";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TextBox txtPesquisa1;
        private Button btn1;
        private TabPage tabPage2;
        private TextBox txtPesquisa2;
        private Button btn2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
    }
}