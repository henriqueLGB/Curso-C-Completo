
namespace EditorTXT
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
            menuBar = new System.Windows.Forms.MenuStrip();
            mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            mEditar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            mExibir = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            mExibirBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            mAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            statusBar = new System.Windows.Forms.StatusStrip();
            statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            toolBarNovo = new System.Windows.Forms.ToolStripButton();
            toolBarAbrir = new System.Windows.Forms.ToolStripButton();
            toolBarSalvar = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            toolBarFonte = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            toolBarZoom = new System.Windows.Forms.ToolStripButton();
            toolBarZoomMenos = new System.Windows.Forms.ToolStripButton();
            toolBarZoomMais = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            toolBarAjuda = new System.Windows.Forms.ToolStripButton();
            txtConteudo = new System.Windows.Forms.RichTextBox();
            menuBar.SuspendLayout();
            statusBar.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mArquivo, mEditar, mFormatar, mExibir, mAjuda });
            menuBar.Location = new System.Drawing.Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new System.Drawing.Size(784, 29);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mArquivoNovo, mArquivoNovaJanela, toolStripSeparator1, mArquivoAbrir, mArquivoSalvar, mArquivoSalvarComo, toolStripSeparator2, mArquivoSair });
            mArquivo.Name = "mArquivo";
            mArquivo.Size = new System.Drawing.Size(80, 25);
            mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            mArquivoNovo.Name = "mArquivoNovo";
            mArquivoNovo.ShortcutKeyDisplayString = "";
            mArquivoNovo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            mArquivoNovo.Size = new System.Drawing.Size(272, 26);
            mArquivoNovo.Text = "Novo";
            mArquivoNovo.Click += mArquivoNovo_Click;
            // 
            // mArquivoNovaJanela
            // 
            mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            mArquivoNovaJanela.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.N;
            mArquivoNovaJanela.Size = new System.Drawing.Size(272, 26);
            mArquivoNovaJanela.Text = "Nova Janela";
            mArquivoNovaJanela.Click += mArquivoNovaJanela_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // mArquivoAbrir
            // 
            mArquivoAbrir.Name = "mArquivoAbrir";
            mArquivoAbrir.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            mArquivoAbrir.Size = new System.Drawing.Size(272, 26);
            mArquivoAbrir.Text = "Abrir";
            mArquivoAbrir.Click += mArquivoAbrir_Click;
            // 
            // mArquivoSalvar
            // 
            mArquivoSalvar.Name = "mArquivoSalvar";
            mArquivoSalvar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            mArquivoSalvar.Size = new System.Drawing.Size(272, 26);
            mArquivoSalvar.Text = "Salvar";
            mArquivoSalvar.Click += mArquivoSalvar_Click;
            // 
            // mArquivoSalvarComo
            // 
            mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            mArquivoSalvarComo.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            mArquivoSalvarComo.Size = new System.Drawing.Size(272, 26);
            mArquivoSalvarComo.Text = "Salvar Como";
            mArquivoSalvarComo.Click += mArquivoSalvarComo_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(269, 6);
            // 
            // mArquivoSair
            // 
            mArquivoSair.Name = "mArquivoSair";
            mArquivoSair.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            mArquivoSair.Size = new System.Drawing.Size(272, 26);
            mArquivoSair.Text = "Sair";
            mArquivoSair.Click += mArquivoSair_Click;
            // 
            // mEditar
            // 
            mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mEditarDesfazer, mEditarRefazer, toolStripSeparator3, mEditarRecortar, mEditarCopiar, mEditarColar, mEditarExcluir, toolStripSeparator4, mEditarDataEHora });
            mEditar.Name = "mEditar";
            mEditar.Size = new System.Drawing.Size(64, 25);
            mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            mEditarDesfazer.Name = "mEditarDesfazer";
            mEditarDesfazer.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z;
            mEditarDesfazer.Size = new System.Drawing.Size(236, 26);
            mEditarDesfazer.Text = "Desfazer";
            mEditarDesfazer.Click += mEditarDesfazer_Click;
            // 
            // mEditarRefazer
            // 
            mEditarRefazer.Name = "mEditarRefazer";
            mEditarRefazer.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Z;
            mEditarRefazer.Size = new System.Drawing.Size(236, 26);
            mEditarRefazer.Text = "Refazer";
            mEditarRefazer.Click += mEditarRefazer_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarRecortar
            // 
            mEditarRecortar.Name = "mEditarRecortar";
            mEditarRecortar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            mEditarRecortar.Size = new System.Drawing.Size(236, 26);
            mEditarRecortar.Text = "Recortar";
            mEditarRecortar.Click += mEditarRecortar_Click;
            // 
            // mEditarCopiar
            // 
            mEditarCopiar.Name = "mEditarCopiar";
            mEditarCopiar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            mEditarCopiar.Size = new System.Drawing.Size(236, 26);
            mEditarCopiar.Text = "Copiar";
            mEditarCopiar.Click += mEditarCopiar_Click;
            // 
            // mEditarColar
            // 
            mEditarColar.Name = "mEditarColar";
            mEditarColar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            mEditarColar.Size = new System.Drawing.Size(236, 26);
            mEditarColar.Text = "Colar";
            mEditarColar.Click += mEditarColar_Click;
            // 
            // mEditarExcluir
            // 
            mEditarExcluir.Name = "mEditarExcluir";
            mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            mEditarExcluir.Size = new System.Drawing.Size(236, 26);
            mEditarExcluir.Text = "Excluir";
            mEditarExcluir.Click += mEditarExcluir_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(233, 6);
            // 
            // mEditarDataEHora
            // 
            mEditarDataEHora.Name = "mEditarDataEHora";
            mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            mEditarDataEHora.Size = new System.Drawing.Size(236, 26);
            mEditarDataEHora.Text = "Data e Hora";
            mEditarDataEHora.Click += mEditarDataEHora_Click;
            // 
            // mFormatar
            // 
            mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mFormatarQuebraLinha, mFormatarFonte });
            mFormatar.Name = "mFormatar";
            mFormatar.Size = new System.Drawing.Size(88, 25);
            mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            mFormatarQuebraLinha.CheckOnClick = true;
            mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            mFormatarQuebraLinha.Size = new System.Drawing.Size(280, 26);
            mFormatarQuebraLinha.Text = "Quebra automática de linha";
            mFormatarQuebraLinha.Click += mFormatarQuebraLinha_Click;
            // 
            // mFormatarFonte
            // 
            mFormatarFonte.Name = "mFormatarFonte";
            mFormatarFonte.Size = new System.Drawing.Size(280, 26);
            mFormatarFonte.Text = "Fonte";
            mFormatarFonte.Click += mFormatarFonte_Click;
            // 
            // mExibir
            // 
            mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mExibirZoom, mExibirBarraStatus });
            mExibir.Name = "mExibir";
            mExibir.Size = new System.Drawing.Size(62, 25);
            mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mExibirZoomAmpliar, mExibirZoomReduzir, mExibirZoomRestaurar });
            mExibirZoom.Name = "mExibirZoom";
            mExibirZoom.Size = new System.Drawing.Size(188, 26);
            mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl + sinal de adição";
            mExibirZoomAmpliar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus;
            mExibirZoomAmpliar.Size = new System.Drawing.Size(321, 26);
            mExibirZoomAmpliar.Text = "Ampliar";
            mExibirZoomAmpliar.Click += mExibirZoomAmpliar_Click;
            // 
            // mExibirZoomReduzir
            // 
            mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl + sinal de subtração";
            mExibirZoomReduzir.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus;
            mExibirZoomReduzir.Size = new System.Drawing.Size(321, 26);
            mExibirZoomReduzir.Text = "Reduzir";
            mExibirZoomReduzir.Click += mExibirZoomReduzir_Click;
            // 
            // mExibirZoomRestaurar
            // 
            mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            mExibirZoomRestaurar.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0;
            mExibirZoomRestaurar.Size = new System.Drawing.Size(321, 26);
            mExibirZoomRestaurar.Text = "Restaurar";
            mExibirZoomRestaurar.Click += mExibirZoomRestaurar_Click;
            // 
            // mExibirBarraStatus
            // 
            mExibirBarraStatus.Checked = true;
            mExibirBarraStatus.CheckOnClick = true;
            mExibirBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            mExibirBarraStatus.Name = "mExibirBarraStatus";
            mExibirBarraStatus.Size = new System.Drawing.Size(188, 26);
            mExibirBarraStatus.Text = "Barra de status";
            mExibirBarraStatus.Click += mExibirBarraStatus_Click;
            // 
            // mAjuda
            // 
            mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mAjudaExibirAjuda, mAjudaSobre });
            mAjuda.Name = "mAjuda";
            mAjuda.Size = new System.Drawing.Size(64, 25);
            mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            mAjudaExibirAjuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            mAjudaExibirAjuda.Size = new System.Drawing.Size(218, 26);
            mAjudaExibirAjuda.Text = "Exibir Ajuda";
            mAjudaExibirAjuda.Click += mAjudaExibirAjuda_Click;
            // 
            // mAjudaSobre
            // 
            mAjudaSobre.Name = "mAjudaSobre";
            mAjudaSobre.Size = new System.Drawing.Size(218, 26);
            mAjudaSobre.Text = "Sobre o Editor TXT";
            mAjudaSobre.Click += mAjudaSobre_Click;
            // 
            // statusBar
            // 
            statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusBarLabel });
            statusBar.Location = new System.Drawing.Point(0, 539);
            statusBar.Name = "statusBar";
            statusBar.Size = new System.Drawing.Size(784, 22);
            statusBar.TabIndex = 1;
            statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            statusBarLabel.Name = "statusBarLabel";
            statusBarLabel.Size = new System.Drawing.Size(38, 17);
            statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolBarNovo, toolBarAbrir, toolBarSalvar, toolStripSeparator5, toolBarFonte, toolStripSeparator6, toolBarZoom, toolBarZoomMenos, toolBarZoomMais, toolStripSeparator7, toolBarAjuda });
            toolStrip1.Location = new System.Drawing.Point(0, 29);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(784, 28);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolBarNovo
            // 
            toolBarNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarNovo.Image = (System.Drawing.Image)resources.GetObject("toolBarNovo.Image");
            toolBarNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarNovo.Name = "toolBarNovo";
            toolBarNovo.Size = new System.Drawing.Size(23, 25);
            toolBarNovo.Text = "Novo";
            toolBarNovo.Click += toolBarNovo_Click;
            // 
            // toolBarAbrir
            // 
            toolBarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarAbrir.Image = (System.Drawing.Image)resources.GetObject("toolBarAbrir.Image");
            toolBarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarAbrir.Name = "toolBarAbrir";
            toolBarAbrir.Size = new System.Drawing.Size(23, 25);
            toolBarAbrir.ToolTipText = "Abrir";
            toolBarAbrir.Click += mArquivoAbrir_Click;
            // 
            // toolBarSalvar
            // 
            toolBarSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarSalvar.Image = (System.Drawing.Image)resources.GetObject("toolBarSalvar.Image");
            toolBarSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarSalvar.Name = "toolBarSalvar";
            toolBarSalvar.Size = new System.Drawing.Size(23, 25);
            toolBarSalvar.Text = "Salvar";
            toolBarSalvar.Click += mArquivoSalvar_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBarFonte
            // 
            toolBarFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolBarFonte.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            toolBarFonte.Image = (System.Drawing.Image)resources.GetObject("toolBarFonte.Image");
            toolBarFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarFonte.Name = "toolBarFonte";
            toolBarFonte.Size = new System.Drawing.Size(23, 25);
            toolBarFonte.Text = "A";
            toolBarFonte.ToolTipText = "Formatar Fonte";
            toolBarFonte.Click += mFormatarFonte_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBarZoom
            // 
            toolBarZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarZoom.Image = (System.Drawing.Image)resources.GetObject("toolBarZoom.Image");
            toolBarZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoom.Name = "toolBarZoom";
            toolBarZoom.Size = new System.Drawing.Size(23, 25);
            toolBarZoom.Text = "Zoom 100%";
            toolBarZoom.Click += mExibirZoomRestaurar_Click;
            // 
            // toolBarZoomMenos
            // 
            toolBarZoomMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            toolBarZoomMenos.ForeColor = System.Drawing.Color.DarkRed;
            toolBarZoomMenos.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoomMenos.Name = "toolBarZoomMenos";
            toolBarZoomMenos.Size = new System.Drawing.Size(23, 25);
            toolBarZoomMenos.Text = "-";
            toolBarZoomMenos.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            toolBarZoomMenos.ToolTipText = "Zoom -";
            toolBarZoomMenos.Click += mExibirZoomReduzir_Click;
            // 
            // toolBarZoomMais
            // 
            toolBarZoomMais.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            toolBarZoomMais.ForeColor = System.Drawing.Color.DarkRed;
            toolBarZoomMais.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarZoomMais.Name = "toolBarZoomMais";
            toolBarZoomMais.Size = new System.Drawing.Size(24, 25);
            toolBarZoomMais.Text = "+";
            toolBarZoomMais.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            toolBarZoomMais.ToolTipText = "Zoom +";
            toolBarZoomMais.Click += mExibirZoomAmpliar_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // toolBarAjuda
            // 
            toolBarAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolBarAjuda.Image = (System.Drawing.Image)resources.GetObject("toolBarAjuda.Image");
            toolBarAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolBarAjuda.Name = "toolBarAjuda";
            toolBarAjuda.Size = new System.Drawing.Size(23, 25);
            toolBarAjuda.Text = "Ajuda";
            toolBarAjuda.Click += mAjudaExibirAjuda_Click;
            // 
            // txtConteudo
            // 
            txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            txtConteudo.Location = new System.Drawing.Point(0, 57);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new System.Drawing.Size(784, 482);
            txtConteudo.TabIndex = 7;
            txtConteudo.Text = "";
            txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(txtConteudo);
            Controls.Add(toolStrip1);
            Controls.Add(statusBar);
            Controls.Add(menuBar);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Editor TXT";
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibirAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRefazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mEditarDataEHora;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolBarNovo;
        private System.Windows.Forms.ToolStripButton toolBarAbrir;
        private System.Windows.Forms.ToolStripButton toolBarSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolBarFonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolBarZoom;
        private System.Windows.Forms.ToolStripButton toolBarZoomMenos;
        private System.Windows.Forms.ToolStripButton toolBarZoomMais;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolBarAjuda;
        private System.Windows.Forms.RichTextBox txtConteudo;
    }
}

