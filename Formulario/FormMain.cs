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

        }
    }
}
