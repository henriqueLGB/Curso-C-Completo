namespace parte024
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
            Container = new SplitContainer();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            picture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Container).BeginInit();
            Container.Panel1.SuspendLayout();
            Container.Panel2.SuspendLayout();
            Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // Container
            // 
            Container.Dock = DockStyle.Fill;
            Container.Location = new Point(0, 0);
            Container.Name = "Container";
            // 
            // Container.Panel1
            // 
            Container.Panel1.BackColor = SystemColors.AppWorkspace;
            Container.Panel1.Controls.Add(button3);
            Container.Panel1.Controls.Add(button2);
            Container.Panel1.Controls.Add(button1);
            Container.Panel1.ForeColor = Color.LightGray;
            // 
            // Container.Panel2
            // 
            Container.Panel2.BackColor = SystemColors.ActiveCaption;
            Container.Panel2.Controls.Add(picture);
            Container.Size = new Size(800, 450);
            Container.SplitterDistance = 266;
            Container.TabIndex = 0;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(3, 95);
            button3.Name = "button3";
            button3.Size = new Size(260, 40);
            button3.TabIndex = 2;
            button3.Text = "Imagem 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 49);
            button2.Name = "button2";
            button2.Size = new Size(260, 40);
            button2.TabIndex = 1;
            button2.Text = "Imagem 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(260, 40);
            button1.TabIndex = 0;
            button1.Text = "Imagem 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // picture
            // 
            picture.Location = new Point(75, 30);
            picture.Name = "picture";
            picture.Size = new Size(414, 391);
            picture.TabIndex = 0;
            picture.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Container);
            Name = "Form1";
            Text = "Form1";
            Container.Panel1.ResumeLayout(false);
            Container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Container).EndInit();
            Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer Container;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox picture;
    }
}