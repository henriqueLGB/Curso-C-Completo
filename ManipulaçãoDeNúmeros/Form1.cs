using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulaçãoDeNúmeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            /*
                int num;
                //bool res = int.TryParse("1985fewfew",out num);

                if (int.TryParse("1985fewfew", out num))
                {
                    lbResultado.Text = num.ToString();
                }
                else
                {
                    lbResultado.Text = "Erro na conversão !";
                }
            */
            #endregion

            #region ToString / Convert.ToString

            //double num = 120;

            //lbResultado.Text = num.ToString("00000.00");
            //lbResultado.Text = num.ToString("#.00");


            //int num = 10;
            //lbResultado.Text = num.ToString("X");  //HEXADECIMAL
            //lbResultado.Text = num.ToString("X2"); //HEXADECIMAL COM 2 DIGITOS
            //lbResultado.Text = num.ToString("D");  //DECIMAL
            //lbResultado.Text = num.ToString("D2");  //Decimal COM 2 DIGITOS
            //lbResultado.Text = num.ToString("C");  //MONETÁRIO

            //lbResultado.Text = Convert.ToString(num,16); //CONVERTE PARA HEXADECIMAL

            #endregion

            #region Math
            /*
            double pi           = Math.PI;
            double E            = Math.E;
            double seno         = Math.Sin(3);
            double coseno       = Math.Cos(3);
            double potencia     = Math.Pow(2 , 2);
            double raizQuadrada = Math.Sqrt(49);
            double arredondar   = Math.Round(158.75);
            double inteiro      = Math.Truncate(32.57);
            double floor        = Math.Floor(52.75);
            double ceil         = Math.Ceiling(52.25);

            lbResultado.Text = ceil.ToString();
            */

            #endregion
        }
    }
}
