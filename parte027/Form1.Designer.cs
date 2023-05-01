namespace parte027
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copiarToolStripMenuItem = new ToolStripMenuItem();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            colorToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, recortarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(119, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.Size = new Size(118, 22);
            recortarToolStripMenuItem.Text = "Recortar";
            recortarToolStripMenuItem.Click += recortarToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Location = new Point(12, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.ContextMenuStrip = contextMenuStrip2;
            textBox2.Location = new Point(12, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(409, 23);
            textBox2.TabIndex = 2;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { colorToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(181, 48);
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "Colar";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem colorToolStripMenuItem;
    }
}