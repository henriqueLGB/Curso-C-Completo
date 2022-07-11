using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        enum Notas
        {
            Minimo = 10,
            Media  = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public string Nome;
            public int Idade;
            public double Altura;
        }

        static void Main(string[] args)
        {
            #region Númericas Integrais
                #region Integral Assinado (suporta negativo)
                sbyte num1 = 10; // 8 bits, de -128 a 127
                    short num2 = 20; // 16 bits, de -32.768 a 32.767
                    int   num3 = 30; // 32 bits, de -2.147.483.648 a 2,147.483.647
                    long  num4 = 40L; // 64 bits, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

                #endregion

                #region Integral sem sinal (Não suporta negativo)
                    byte    num5 = 10; // 8 bits , interavalo de 0 a 255
                    ushort  num6 = 20; // 16 bits, de 0 a 65.535
                    uint    num7 = 30; // 32 bits, de 0 a 4.294.967.295
                    ulong   num8 = 40L;// 64 bits, de 0 a 18.446.744.073.709.551.615
            #endregion

            //Console.Write(num5);
            //Console.ReadKey();

            #endregion

            #region Números Reais
                float   real1 = 100.75f;        //32 bits
                double  real2 = 500.754;        //64 bits
                decimal real3 = 752538.457m;    //128 bits
            #endregion

            #region Tipo Caractere

                char letra  = 'C';       //Permite somente uma letra
                char letra2 = '\u0061'; //Insere a letra através do código da mesma
                char escape = '\n';     //Caractere de escape

            //Console.Write(letra2);
            //Console.ReadKey();

            #endregion

            #region Tipo Boolean

                bool verificar = false;
                verificar = true;

            #endregion

            #region Tipo String
                string texto        = "Henrique Lira \n 2022";
                string ignoraEscape = @"Henrique Lira \n 2022";
                string mensagem     = null;
                mensagem            = texto;
            #endregion

            #region Tipo Var 
                
                //Assume o valor na inicialização  
                var valor   = 140;
                var text    = "texto";
                var verify  = false;

            #endregion

            #region Tipo Object
                
                //Object é a base para todo os valores
                //Podendo alterar seu tipo ao longo
                object obj = 100;
                obj = false;
                obj = "Henrique";

            #endregion

            #region Tipo Constante
                //O valor deve ser definido na sua criação, seu valor não pode ser alterado
                const double pi = 3.1415;
            #endregion

            #region Tipo Enum 
                Notas notasAlunos = Notas.Minimo;
            #endregion

            #region Struct 

                Pessoa p1 = new Pessoa();

                p1.Nome     = "Henrique";
                p1.Idade    = 22;
                p1.Altura   = 1.83;

                Pessoa p2 = new Pessoa()
                {
                    Nome    = "Arthur",
                    Idade   = 11,
                    Altura  = 1.37
                };

                /*
                Console.Write(p1.Nome);
                Console.Write(p1.Idade);
                Console.Write(p1.Altura);

                Console.ReadKey();
                */

            #endregion

        }
    }
}
