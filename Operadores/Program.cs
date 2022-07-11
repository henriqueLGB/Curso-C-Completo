using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operações Aritéticos 

            /*
            int num1 = 10;
            int num2 = 2;
            //int resultado = num1 + num2;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2); //Resto da divisão

            Console.ReadKey();
            */

            #endregion

            #region Precedência de Operadores

            /*
            double num1 = 100;
            double num2 = 10;
            double num3 = 5;

            double res = (num1 + num2) * (num3 / 3);
              
            Console.WriteLine(res);
            Console.ReadKey();

            */

            #endregion

            #region Operadores de Icremento e Decremento

            /*
            int num1 = 10;

            //num1 = num1 + 1;
            //++num1;
            num1++;

            //num1 = num1 - 1;
            //--num1;
            num1--;

            Console.WriteLine(num1);
            Console.ReadKey();
                
            */

            #endregion

            #region Concatenação 

            /*
            string nome         = "Henrique ";
            string sobreNome    = "Lira";
            string nomeCompleto = nome + sobreNome;

            Console.WriteLine(nomeCompleto);
            Console.ReadKey();
            */

            #endregion

            #region Operadores de Atribuição

            /*
            int num1 = 10;

            //num1 = num1 + 20;
            //num1 += 20;
            //num1 -= 2;
            //num1 *= 5;
            //num1 /= 2;
            //num1 %= 2;

            string nome = "Henrique ";
            nome += "Lira";

            Console.WriteLine(num1);
            Console.WriteLine(nome);
            Console.ReadLine();
            */

            #endregion

            #region Operadores de Igualdade / Comparação


            /*
            string nome = "Henrique";

            bool res  = 100 == (50 * 2);
            bool res2 = (200 / 2) != (100 + 100);
            bool res3 = nome == "Henrique";

            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.ReadLine(); 

            */

            #endregion

            #region Operadores Relacionais 

            /*
             * 
            //bool res = 100 < (50 * 2);
            //bool res = 100 > 50;
            //bool res = 45 <=  (50 * 2);
            bool res = 100 >= (50 * 2);

            Console.WriteLine(res);
            Console.ReadLine();

            */

            #endregion

            #region Operadores Lógicos 

            /*
            bool res1 = 100 >= 50;
            bool res2 = 60 == 50;

            bool final  = res1 && res2;
            bool final2 = (100 >= 50) || (60 == 50);

            Console.WriteLine(final2);
            Console.ReadKey();
            */

            #endregion

            #region Exércicio Conversor de Temperatura

            double c, f, k;

            Console.WriteLine("### Conversor de Temperaturas ###");
            Console.Write("Insira a temperatura em Celcius: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");

            //(c * 9/5) + 32 = F
            f = (c * 9 / 5) + 32;

            //c + 273,15
            k = (c + 273.15);

            Console.WriteLine(c + " graus Celcius " + f + " graus em fahrenheit");
            Console.WriteLine(c + " graus Celcius " + k + " graus em Kelvin");

            Console.WriteLine("----------------------------");

            Console.ReadKey();

            #endregion

        }
    }
}
