namespace parte029
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusProgess = new ToolStripProgressBar();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            zoom100ToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem1 = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton1 = new ToolStripSplitButton();
            nOVOToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel, statusProgess, toolStripDropDownButton1, toolStripSplitButton1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(38, 17);
            statusLabel.Text = "100 %";
            // 
            // statusProgess
            // 
            statusProgess.Name = "statusProgess";
            statusProgess.Size = new Size(100, 16);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { zoom100ToolStripMenuItem, zoomToolStripMenuItem1, zoomToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.BAUCIUS_mage_03d12452_bf58_477e_a64d_1785d492e7e0__2_;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 20);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // zoom100ToolStripMenuItem
            // 
            zoom100ToolStripMenuItem.Name = "zoom100ToolStripMenuItem";
            zoom100ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + 0";
            zoom100ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            zoom100ToolStripMenuItem.Size = new Size(183, 22);
            zoom100ToolStripMenuItem.Text = "Zoom 100%";
            zoom100ToolStripMenuItem.Click += zoom100ToolStripMenuItem_Click;
            // 
            // zoomToolStripMenuItem1
            // 
            zoomToolStripMenuItem1.Name = "zoomToolStripMenuItem1";
            zoomToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + '-'";
            zoomToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomToolStripMenuItem1.Size = new Size(183, 22);
            zoomToolStripMenuItem1.Text = "Zoom -";
            zoomToolStripMenuItem1.Click += zoomToolStripMenuItem1_Click;
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + '+'";
            zoomToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomToolStripMenuItem.Size = new Size(183, 22);
            zoomToolStripMenuItem.Text = "Zoom +";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { nOVOToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // nOVOToolStripMenuItem
            // 
            nOVOToolStripMenuItem.Name = "nOVOToolStripMenuItem";
            nOVOToolStripMenuItem.Size = new Size(180, 22);
            nOVOToolStripMenuItem.Text = "Novo";
            nOVOToolStripMenuItem.Click += nOVOToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Name = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripProgressBar statusProgess;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem zoom100ToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem1;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem nOVOToolStripMenuItem;
    }
}