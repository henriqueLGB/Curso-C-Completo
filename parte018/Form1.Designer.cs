namespace parte018
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
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            button1 = new Button();
            toolTip2 = new ToolTip(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Informação do Objeto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 130);
            label1.Name = "label1";
            label1.Size = new Size(279, 37);
            label1.TabIndex = 0;
            label1.Text = "Formulário Principal";
            toolTip1.SetToolTip(label1, "Título do Formulário");
            // 
            // button1
            // 
            button1.Location = new Point(324, 196);
            button1.Name = "button1";
            button1.Size = new Size(153, 50);
            button1.TabIndex = 1;
            button1.Text = "button1";
            toolTip1.SetToolTip(button1, "Botão para executar uma tarefa");
            toolTip2.SetToolTip(button1, "Clique só uma vez no botão");
            button1.UseVisualStyleBackColor = true;
            // 
            // toolTip2
            // 
            toolTip2.ToolTipIcon = ToolTipIcon.Warning;
            toolTip2.ToolTipTitle = "Aviso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 167);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Bem vindo";
            toolTip2.SetToolTip(label2, "Aviso de boas vindas");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Label label1;
        private Button button1;
        private ToolTip toolTip2;
        private Label label2;
    }
}