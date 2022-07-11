using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            byte num1 = 100; //8 bits 
            ushort num2; //16 bits

            float num3  = 1250.45f;
            double num4 = num3;

            num2 = num1;
            num3 = num1;

            int numerico = 'c';
            #endregion

            #region Conversão Explícita
            ushort num5 = 500;
            byte   num6 = (byte)num5;

            float num7 = 2500f;
            int num8 = (int)num7;

            char letra = (char)97;

            #endregion

            #region Método Parse
            string txtNumero = "1985";

            //Convertendo para número
            int numero = int.Parse(txtNumero);
            byte num9 = byte.Parse("120");
            double num10 = double.Parse("1254454,32");
            float num11 = float.Parse("457,75");

            #endregion

            #region Classe Convert

            string texto = Convert.ToString(2500);
            double num12 = Convert.ToDouble(false);
            int num13 = Convert.ToInt32('C');

            #endregion
        }
    }
}
