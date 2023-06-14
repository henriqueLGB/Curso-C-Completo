using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace TransferenciaArquivoCliente
{
    public class FTCliente
    {
        static IPEndPoint ipEnd_Client;
        static Socket clientSock_cliente;
        public static string EnderecoIp = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {

                ipEnd_Client = new IPEndPoint(IPAddress.Parse(EnderecoIp),PortaHost);
                clientSock_cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta   = arquivo.Substring(0,arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivosByte = Encoding.UTF8.GetBytes(arquivo);

                if(nomeArquivosByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() =>
                    {
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanho do arquivo é maior que 50Mb, tente um arquivo menor.";
                    }));

                    return;
                }

                string caminhoCompleto  = pasta + arquivo;
                byte[] fileData         = File.ReadAllBytes(caminhoCompleto);
                byte[] clienteData      = new byte[4 + nomeArquivosByte.Length + fileData.Length];
                byte[] nomeArquivoLen   = BitConverter.GetBytes(nomeArquivosByte.Length);

                nomeArquivoLen.CopyTo(clienteData, 0);
                nomeArquivosByte.CopyTo(clienteData, 0);
                fileData.CopyTo(clienteData, 4 + nomeArquivosByte.Length);

                clientSock_cliente.Connect(ipEnd_Client);
                clientSock_cliente.Send(clienteData,0,clienteData.Length,0);
                //clientSock_cliente.Close();

                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Green;
                    LabelMensagem.Text = "Arquivo [ "+arquivo+"] transferido.";
                }));

            }
            catch(Exception ex)
            {
                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Falha, O servidor não está atendendo..." + ex.Message;
                }));
            }
            finally
            {
                clientSock_cliente.Disconnect(false);
                clientSock_cliente.Close();
            }
        }


    }
}
