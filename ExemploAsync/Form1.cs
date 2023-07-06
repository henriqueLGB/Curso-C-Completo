using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploAsync
{
    public partial class Form1 : Form
    {

        public static ListBox lstRes;
        public Form1()
        {
            InitializeComponent();
            lstRes = listaResultados;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Add("Evento do botão foi iniciado : clique aqui");

            Exemplo obj = new Exemplo();
            obj.TaskLongaDuracao();

            listaResultados.Items.Add("Evento do botão foi concluído");
        }

        private async void btnExecAsync_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Add("Evento do botão foi iniciado : clique aqui");

            ExemploAsync obj = new ExemploAsync();
            await obj.TaskLongaDuracao();

            listaResultados.Items.Add("Evento do botão foi concluído");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listaResultados.Items.Clear();
        }
    }
}
