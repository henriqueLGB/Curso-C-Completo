﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    //Esta classe trata as conexões, serão tantas quanto as instâncias de usuários conectados
    public class Conexao
    {
        TcpClient tcpCliente;

        //A threadque ira enviar a informação para o cliente
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter  swEnviador;
        private string usuarioAtual;
        private string strResposta;

        //O construtor da classe que toma a conexão TCP
        public Conexao(TcpClient tcpCon)
        {
            tcpCliente = tcpCon;

            //A thread que aceita o cliente e espera a mensagem
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;

            //A thread chama o método AceitaCliente()
            thrSender.Start();
        }

        private void FechaConexao()
        {
            //Fecha os objetos abertos
            tcpCliente.Close();
            srReceptor.Close();
            swEnviador.Close();
        }


        //Ocorre quando um cliente novo é aceito
        private void AceitaCliente()
        {
            srReceptor = new StreamReader(tcpCliente.GetStream());
            swEnviador = new StreamWriter(tcpCliente.GetStream());

            //Lê as informaçõesda conta do cliente
            usuarioAtual = srReceptor.ReadLine();
            
            //Temos uma resposta do cliente
            if(usuarioAtual != "")
            {
                //Armazena o nome do usuário na hash table
                if(Servidor.htUsuarios.Contains(usuarioAtual) == true)
                {
                    // 0 => significa não conectado
                    swEnviador.WriteLine("0 | Este nome de usuário já existe. ");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else if(usuarioAtual == "Administrador")
                {
                    // 0 => não conectado
                    swEnviador.WriteLine("0 | Este nome de usuário é reservado. ");
                    swEnviador.Flush();
                    FechaConexao();
                    return;
                }
                else
                {
                    // 1 => conectou com sucesso
                    swEnviador.WriteLine("1");
                    swEnviador.Flush();
                    
                    //Inclui o usuário na hash table e inicia a escuta de suas mensagens
                    Servidor.IncluirUsuario(tcpCliente, usuarioAtual);  
                }
            }
            else
            {
                FechaConexao();
                return;
            }


            try
            {
                //Continua aguardando por uma mensagem do usuário
                while((strResposta = srReceptor.ReadLine()) != null)
                {
                    //Se for inválido remove-o
                    if(strResposta == null)
                    {
                        Servidor.RemoveUsuario(tcpCliente);
                    }
                    else
                    {
                        //Envia a mensagem para todos os outros Usuários
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            }
            catch
            {
                //Se houver algum problema com este usuário , desconecta-o
                Servidor.RemoveUsuario(tcpCliente);
            }

        }

    }
}
