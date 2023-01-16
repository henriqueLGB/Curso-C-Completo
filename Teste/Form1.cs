using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Text = "Henrique Lira";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Carregando a Form";
        }

        private void Teste_Click(object sender, EventArgs e)
        {
            lbTitulo.Text = "Título alterado";
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            lbTitulo.Text = "Mouse entrou";
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            lbTitulo.Text = "Mouse Saiu";
        }
    }
}
