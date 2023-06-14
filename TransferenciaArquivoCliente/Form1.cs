using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferenciaArquivoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.LabelMensagem = lbStatus;
        }

        private void lbArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar Arquivo";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                lbArquivo.Text = dialog.FileName;
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndereco.Text) || 
                string.IsNullOrEmpty(numericPorta.Value.ToString()) ||
                lbArquivo.Text == "Clique para selecionar um arquivo...")
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Dados Inválidos";
                return;
            }

            string enderecoIP   = txtEndereco.Text;
            int porta           = (int) numericPorta.Value;
            string nomeArquivo  = lbArquivo.Text;

            FTCliente.EnderecoIp = enderecoIP;
            FTCliente.PortaHost  = porta;

            try
            {

                Task.Factory.StartNew(() =>
                {
                    FTCliente.EnviarArquivo(nomeArquivo);
                });

            }catch(Exception ex)
            {
                lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Erro :\n" + ex.Message;
            }

        }
    }
}
