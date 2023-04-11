namespace Formulario
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSecunda = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.MHelpSobreDesenv = new System.Windows.Forms.ToolStripMenuItem();
            this.MHelpSobreVer = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.MenuPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(791, 164);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecunda
            // 
            this.btnSecunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecunda.Location = new System.Drawing.Point(12, 373);
            this.btnSecunda.Name = "btnSecunda";
            this.btnSecunda.Size = new System.Drawing.Size(203, 78);
            this.btnSecunda.TabIndex = 1;
            this.btnSecunda.Text = "Secunda Form";
            this.btnSecunda.UseVisualStyleBackColor = true;
            this.btnSecunda.Click += new System.EventHandler(this.btnSecunda_Click);
            // 
            // btnThread
            // 
            this.btnThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread.Location = new System.Drawing.Point(221, 373);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(203, 78);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "Secunda Form Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp,
            this.comboMenu,
            this.MenuPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(815, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MFileNovo,
            this.MFileAbrir,
            this.toolStripSeparator1,
            this.MFileSair});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 23);
            this.MenuFile.Text = "File";
            // 
            // MFileNovo
            // 
            this.MFileNovo.Name = "MFileNovo";
            this.MFileNovo.Size = new System.Drawing.Size(180, 22);
            this.MFileNovo.Text = "Novo";
            this.MFileNovo.Click += new System.EventHandler(this.noovoToolStripMenuItem_Click);
            // 
            // MFileAbrir
            // 
            this.MFileAbrir.Name = "MFileAbrir";
            this.MFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.MFileAbrir.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MFileSair
            // 
            this.MFileSair.Name = "MFileSair";
            this.MFileSair.Size = new System.Drawing.Size(180, 22);
            this.MFileSair.Text = "Sair";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MHelpSobre});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 23);
            this.MenuHelp.Text = "Help";
            // 
            // MHelpSobre
            // 
            this.MHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MHelpSobreDesenv,
            this.MHelpSobreVer});
            this.MHelpSobre.Name = "MHelpSobre";
            this.MHelpSobre.Size = new System.Drawing.Size(180, 22);
            this.MHelpSobre.Text = "Sobre";
            // 
            // MHelpSobreDesenv
            // 
            this.MHelpSobreDesenv.Name = "MHelpSobreDesenv";
            this.MHelpSobreDesenv.Size = new System.Drawing.Size(180, 22);
            this.MHelpSobreDesenv.Text = "Desenvolvedor";
            // 
            // MHelpSobreVer
            // 
            this.MHelpSobreVer.Name = "MHelpSobreVer";
            this.MHelpSobreVer.Size = new System.Drawing.Size(180, 22);
            this.MHelpSobreVer.Text = "Versão";
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 23);
            // 
            // MenuPesquisar
            // 
            this.MenuPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuPesquisar.Name = "MenuPesquisar";
            this.MenuPesquisar.Size = new System.Drawing.Size(100, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 463);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnSecunda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSecunda;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MFileNovo;
        private System.Windows.Forms.ToolStripMenuItem MFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MFileSair;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem MHelpSobreDesenv;
        private System.Windows.Forms.ToolStripMenuItem MHelpSobreVer;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox MenuPesquisar;
    }
}

