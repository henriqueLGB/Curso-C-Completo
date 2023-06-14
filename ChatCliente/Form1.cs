using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {

        //Trata o nome do usuário
        private string NomeUsuario;
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;

        //Necessário para atualizar o formulário com mensagens de outra thread
        private delegate void AtualizarLogCallBack(string strMensagem);

        //Necessário para definir o formulário para o estado 'disconnected' de outra thread
        private delegate void FecharConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIp;
        private int portaHost;
        private bool conectado;

        public Form1()
        {
            //Na saída da aplicação : desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Se não está conectado aguarda conexão
            if (!conectado)
            {
                InicializarConexao();
            }
            else
            {
                //Se está conetado então desconecta
                FechaConexao("Desconectado a pedido do usuário");
            }
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se pressionou a tecla Enter
            if(e.KeyChar == (char)13)
            {
                EnviarMensagem();
            }
        }

        private void InicializarConexao()
        {
            try
            {
                //Trata o endereço IP informado em um objeto IPAdress
                enderecoIp = IPAddress.Parse(txtEndereco.Text);

                //Trata o número da porta do host
                portaHost = (int)numericPorta.Value;

                //Inicia uma nova conexão TCP com o servidor chat
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIp, portaHost);

                //Ajuda a verificar se estamos conectados ou não
                conectado = true;

                //Prepara o formulário
                NomeUsuario = txtUsuario.Text;

                //Desabilita e habilita os campos apropriados
                txtEndereco.Enabled = false;
                numericPorta.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnEnviarMensagem.Enabled = true;
                btnConectar.ForeColor = Color.Red;
                btnConectar.Text = "Desconectar";

                //Enviar o nome do usuário ao servidor
                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtUsuario.Text);
                stwEnviador.Flush();

                //Inicia a thread para receber mensagens e nova comunicação
                mensagemThread = new Thread(new ThreadStart(RecebeMensagem));
                mensagemThread.IsBackground = true;
                mensagemThread.Start();

                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Green;
                    lbStatus.Text = "Conectado";
                }));


            }
            catch(Exception ex) 
            {
                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Red;
                    lbStatus.Text = "Erro na conexão com o servidor: \n" + ex.Message;
                }));
            }
        }

        private void RecebeMensagem()
        {
            //recebe a resposta do servidor
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string conResposta = strReceptor.ReadLine();

            //Se o primeiro caractere da resposta é 1 a conexão foi feita com sucesso
            if (conResposta[0] == '1')
            {
                //Atualiza o formulário para informar que está conectado
                this.Invoke(new AtualizarLogCallBack(this.AtualizaLog),new object[] {"Conectado com sucesso!"});
            }
            else
            {
                //Se o primeiro caractere da resposta não for 1 a conexão falhou
                string motivo = "Não conectado: ";
                motivo += conResposta.Substring(2, conResposta.Length - 2);

                //Atualiza o formulário com o motivo da falha na conexão
                this.Invoke(new FecharConexaoCallBack(this.FechaConexao), new object[] { motivo });

                //Sai do método
                return;
            }


            //Enquanto estiver conectado lê as linhas que estão chegando do servidor
            while (conectado)
            {
                //Exibe as mensagens no TextBox
                this.Invoke(new AtualizarLogCallBack(this.AtualizaLog), new object[] { strReceptor.ReadLine() });
            }

        }

        public void AtualizaLog(string strMensagem)
        {
            //Anexa o texto ao final de cada linha
            txtLog.AppendText(strMensagem + "\r\n");
        }

        public void EnviarMensagem()
        {
            //Envia a mensagem para o servidor
            if(txtMensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(txtMensagem.Text);
                stwEnviador.Flush();
                txtMensagem.Lines = null;
            }

            //Para limpar o campo
            txtMensagem.Text = "";

        }

        private void FechaConexao(string Motivo)
        {
            //Fecha a conexão com o servidor
            //Mostra o motivo porque a conexão encerrou
            txtLog.AppendText(Motivo + "\r\n");

            //Habilita e desabilita os controles apropriados no formulário
            txtEndereco.Enabled = true;
            numericPorta.Enabled = true;
            txtUsuario.Enabled = true;
            txtMensagem.Enabled = false;
            btnEnviarMensagem.Enabled = false;
            btnConectar.ForeColor = Color.Green;
            btnConectar.Text = "Conectar";

            //Fechar os objetos
            conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();

            lbStatus.Invoke(new Action(() =>
            {
                lbStatus.ForeColor = Color.Green;
                lbStatus.Text = $"Desconectado do Servidor de Chat {enderecoIp}:{portaHost}";
            }));

        }

        //O tratador de evento para a saida da aplicação
        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (conectado)
            {
                //Fecha as conexões, streams, etc..
                conectado = false;
                stwEnviador.Close();
                strReceptor.Close();
                tcpServidor.Close();

                lbStatus.Invoke(new Action(() =>
                {
                    lbStatus.ForeColor = Color.Green;
                    lbStatus.Text = $"Desconectado do Servidor de Chat {enderecoIp}:{portaHost}";
                }));
            }
        }

    }
}
