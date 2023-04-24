using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSecunda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSecunda f = new FormSecunda("Henrique Lira");
            //f.Mensagem   = "Henrique Lira";
            //f.Show();
            f.ShowDialog();

            if (!String.IsNullOrEmpty(f.Mensagem))
            {
                lblTitulo.Text = f.Mensagem;
            }

            this.Show();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormSecunda()));
            t.Start();
        }

        private void noovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void MFileAbrir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSecunda f = new FormSecunda();
            f.ShowDialog();
            this.Show();
        }

        private void MFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MHelpSobreDesenv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Henrique Lira");
        }

        private void MHelpSobreVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMenu.SelectedIndex == 0)
            {
                MenuFile.Text = "File";
                MenuHelp.Text = "Help";
            }
            else
            {
                MenuFile.Text = "Arquivo";
                MenuHelp.Text = "Ajuda";
            }
        }

        private void MenuPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                lblTitulo.Text = MenuPesquisar.Text;
                MenuPesquisar.Text = "";
            }
        }
    }
}
