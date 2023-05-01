namespace parte032
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
            bgWorker = new System.ComponentModel.BackgroundWorker();
            lblProgresso = new Label();
            btnStart = new Button();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // bgWorker
            // 
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = true;
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.ProgressChanged += bgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
            // 
            // lblProgresso
            // 
            lblProgresso.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgresso.Location = new Point(240, 88);
            lblProgresso.Name = "lblProgresso";
            lblProgresso.Size = new Size(310, 110);
            lblProgresso.TabIndex = 0;
            lblProgresso.Text = "0 %";
            lblProgresso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(216, 273);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(169, 67);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(403, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 67);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(216, 201);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(356, 36);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(lblProgresso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private Label lblProgresso;
        private Button btnStart;
        private Button btnCancel;
        private ProgressBar progressBar;
    }
}