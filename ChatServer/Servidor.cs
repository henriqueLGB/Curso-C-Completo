using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //Este delegate é necessário para especificar os parametros que estamos passando com o nosso evento
    public delegate void StatusChangedEventHadler(Object sender, StatusChangedEventArgs e); 

    public class Servidor
    {
        //Este hash table armazena os usuários e as conexões (acessando/consultando por usuário)
        public static Hashtable htUsuarios = new Hashtable(30); //30 usuários é o limite definido

        //Este hash table armazena os usuários e as conexões (acessando/consultando por usuário)
        public static Hashtable htConexoes = new Hashtable(30);

        //Armazena o endereço IP passado
        private IPAddress enderecoIp;
        private int portaHost;
        private TcpClient tcpCliente;

        //O evento e o seu argumento irá notificar o formulário quando um usuário se conecta , desconecta
        public static event StatusChangedEventHadler StatusChanged;
        private static StatusChangedEventArgs e;

        //O Construtor define o endereço IP para aquele retornado pela instanciação do objeto
        public Servidor(IPAddress endereco, int porta)
        {
            enderecoIp = endereco;
            portaHost = porta;      
        }

        //A Thread que ira tratar o escutador conexões
        private Thread thrListener;

        //O objeto TCP object que escuta as conexões
        private TcpListener tlsCliente;

        //Ira dizer ao laço while para manter a monitoração das conexões
        bool ServRodando = false;

        //Inclui o usuário nas tabelas hash
        public static void IncluirUsuario(TcpClient tcpUsuario, string strUserName)
        {
            //Primeiro incluir o nome e conexão associada para ambas as hash tables
            Servidor.htUsuarios.Add(strUserName, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUserName);

            //Informar a nova conexão para todos os usuários e para o formulário do servidor
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + "Entrou.... ");
        }

        //Remove o usuário das tabelas  hash tables
        public static void RemoveUsuario(TcpClient tcpUsuario)
        {
            if (htConexoes[tcpUsuario] != null)
            {
                //Primeiro mostra a informação e informa os outros usuários sobre a conexão
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + "Saiu.... "); 

                //Remover o usuário da hash table
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario); 
            }
        }

        //Este evento  é chamado quando queremos disparar o evento StatusChanged
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHadler statusHandler = StatusChanged;

            if(statusHandler != null)
            {
                //Invoca o delegate
                statusHandler(null, e);

            }

        }

        //Enviar mensagens administrativas
        public static void EnviaMensagemAdmin(string mensagem)
        {
            StreamWriter swSender;

            //Exibe primeiro na aplicação
            e = new StatusChangedEventArgs("Administrador: " + mensagem);
            OnStatusChanged(e);

            //Criar um array de clientes TCPs do tamanho do número de clientes exitentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            //Copia os objetos TCPClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //Percorrer a lista de clientes TCP
            for(int i = 0; i < tcpClientes.Length; i++)
            {
                //Tentar enviar uma mensagem para cada cliente
                try
                {

                    //Se a mensagem estiver em branco ou a conexão for nula sai...
                    if(mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }


                    //Envia a mensagem para o usuário atual do laço
                    swSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSender.WriteLine("Administrador: " + mensagem);
                    swSender.Flush();
                    swSender = null;

                }catch
                {
                    //Se houver algum problema, o usuário não existe, então remova-o
                    RemoveUsuario(tcpClientes[i]);
                }
            }

        }

        //Envia mensagens de um usuário para todos os outros
        public static void EnviaMensagem(string origem, string mensagem)
        {
            StreamWriter swSender;

            //Primeiro exibe a mensagem na aplicação
            e = new StatusChangedEventArgs(origem + " disse: " + mensagem);
            OnStatusChanged(e);

            //Criar um array de clientes TCPs do tamanho do número de clientes exitentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];

            //Copia os objetos TCPClient no array
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            //Percorrer a lista de clientes TCP
            for (int i = 0; i < tcpClientes.Length; i++)
            {
                //Tentar enviar uma mensagem para cada cliente
                try
                {

                    //Se a mensagem estiver em branco ou a conexão for nula sai...
                    if (mensagem.Trim() == "" || tcpClientes[i] == null)
                    {
                        continue;
                    }


                    //Envia a mensagem para o usuário atual do laço
                    swSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSender.WriteLine(origem + " disse: " + mensagem);
                    swSender.Flush();
                    swSender = null;

                }
                catch
                {
                    //Se houver algum problema, o usuário não existe, então remova-o
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento()
        {
            try
            {

                //Pega o IP
                IPAddress ipLocal = enderecoIp;
                int portaLocal = portaHost;

                //Criar um objeto de TCP listener usando o IP do servidor e porta definidas
                tlsCliente = new TcpListener(ipLocal, portaLocal);

                //Inicia o TCP listener e escuta as conexões
                tlsCliente.Start();

                //O laço while verifica se servidor está rodando antes de checar as conexões
                ServRodando = true;

                //Inicia uma nova thread que hospeda o listener
                thrListener = new Thread(MantemAtendimentos);
                thrListener.IsBackground = true;
                thrListener.Start();

            }catch(Exception ex)
            {

            }
        }

        private void MantemAtendimentos()
        {
            //Enquanto o servidor estiver rodando
            while (ServRodando)
            {
                //Aceita uma conexão pendente
                tcpCliente = tlsCliente.AcceptTcpClient();

                //Cria uma nova instância da conexão
                Conexao newConnection = new Conexao(tcpCliente);
            }
        }

    }
}
