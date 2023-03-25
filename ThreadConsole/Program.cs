using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEFINIÇÃO DA THREAD
            Thread t = new Thread(new ThreadStart(Tarefa));

            //DEFINE QUE A THREAD TERÁ BACKGROUND
            t.IsBackground = true;

            //INICIA A THREAD
            t.Start();

            //FAZ COM QUE TODA THREAD SEJA EXECUTADA ANTES DE CONTINUAR EXECUTANDO O MÉTODO 
            t.Join(); 

            for (int i = 0;i < 10; i++)
            {
                Console.WriteLine("Principal");

                //DA UM PAUSA EM MILISSEGUNDOS NA THREAD
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            for(int i = 0;i < 10; i++) 
            {
                Console.WriteLine("Tarefa executada");
                Thread.Sleep(1000);
            }
        }
    }
}
