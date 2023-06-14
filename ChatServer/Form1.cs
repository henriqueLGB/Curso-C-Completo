using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallBack(string strMensagem);
        bool conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                Application.Exit();
                return;
            }


            if(txtEndereco.Text == string.Empty)
            {
                MessageBox.Show("informe o endereço IP.");
                txtEndereco.Focus();
                return;
            }

            try
            {

                //Analisa o endereço ip do servidor  informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtEndereco.Text);
                int portaHost = (int)numericPorta.Value;

                //Cria uma nova instância do objeto ChatServidor
                Servidor mainServidor = new Servidor(enderecoIP,portaHost);

                //Vincular o tratamento de evento StatusChanged a mainServer_StatusChanged
                Servidor.StatusChanged += new StatusChangedEventHadler(mainServidor_StatusChanged);

                //Iniciar o atendimento das conexões
                mainServidor.IniciaAtendimento();

                //Mostrar que nos iniciamos o atendimento para conexões
                listLog.Items.Add("Servidor ativo, aguardando usuários conectarem-se ....");
                listLog.SetSelected(listLog.Items.Count - 1, true);

            }
            catch(Exception ex)
            {
                listLog.Items.Add("Erro de conexão : " + ex.Message);
                listLog.SetSelected(listLog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtEndereco.Enabled = false;
            numericPorta.Enabled = false;

            btnStartServer.ForeColor = Color.Red;
            btnStartServer.Text = "Sair";

        }


        public void mainServidor_StatusChanged(object sender,StatusChangedEventArgs e)
        {
            //Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallBack(this.AtualizaStatus), new object[] {e.EventMessage});    
        }


        private void AtualizaStatus(string strMensagem)
        {
            //Atualiza o logo com mensagens
            listLog.Items.Add(strMensagem);
            listLog.SetSelected(listLog.Items.Count - 1, true);
        }

    }
}
