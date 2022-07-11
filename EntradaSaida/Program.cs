using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            #region Saida de Dados
                Console.WriteLine("Henrique Lira"); //Imprime pulando linha
                Console.Write("Gonçalves"); //Imprime Sem Pular Linha
            #endregion

            #region Entrada de Dados

                //Captura uma tecla digitada
                //int codigo = Console.Read();
                //Console.WriteLine(codigo);

                string nome = Console.ReadLine();
                Console.WriteLine(nome);

                Console.ReadKey();

            #endregion


        }
    }
}
