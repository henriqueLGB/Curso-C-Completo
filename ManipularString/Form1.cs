using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            #region Contains/ToString
            /*
                string texto = "Esse tipo de variavél é alfanumerica";
                if (texto.Contains("var"))
                {
                    label1.Text = "Contém.";
                }
                else
                {
                    label1.Text = "Não contém.";
                }*/

            //MÉTODO TOSTRING()
            /*int num = 5400;
            bool res = true;

            label1.Text = num.ToString();
            label1.Text = res.ToString();
        */
            #endregion

            #region ToUpper/ToLower
            /*string nome  = "henrique";
    
            label1.Text = nome.ToUpper();
            label1.Text = nome.ToLower();
            */
            #endregion

            #region IndexOf/LastIndexOf
            /*
                string nome = "Henrique Lira";
         
                int indice  = nome.IndexOf('a');
                int indice2 = nome.IndexOf("Lira");
                int indice3 = nome.IndexOf('e',5);
                int indice4 = nome.IndexOf('e', 5,4);

                int indice = nome.LastIndexOf("Lira");

                label1.Text = "Indice: " + indice;
            */

            #endregion

            #region Insert/Replace
            /*
'
            */

            #endregion

            #region Length/SubString

            /*
                string nome = "Henrique Lira";

                int size = nome.Length;

                label1.Text = "O nome: " + nome + " contém : " + size + " Letras";

                for(var i = 0; i < size; i++) 
                {
                    label1.Text += nome[i] + " \n";
                }

                string parte = nome.Substring(0, 8);
                string parte2 = nome.Substring(9);

                label1.Text = parte2;
            */

            #endregion

            #region Split

            /*
                string nomes = "Henrique_Danny-Gabriel Felipe";

                char[] separador = { ' ', '_', '-' };

                string[] resultado = nomes.Split(separador);

                foreach(string nome in resultado)
                {
                    label1.Text += nome + " \n";
                }
            */

            #endregion

            #region StartsWith/EndsWith

            /*
                
                string nome = "Henrique";

                //bool res = nome.StartsWith("Henr",StringComparison.OrdinalIgnoreCase);
                bool res = nome.EndsWith("que");

                if(res)
                {
                    label1.Text = "Positivo";
                }
                else
                {
                    label1.Text = "Negativo";
                }
            */
            #endregion

            #region Trim/TrimStart/TrimEnd

            /*
            string mensagem = " _Olá Henrique_--5 ";

            char[] c = {' ', '-', '_', '5' };

            //label1.Text = ">" + mensagem.Trim(c) + "<";
            //label1.Text = ">" + mensagem.TrimStart(c) + "<";
            //label1.Text = ">" + mensagem.TrimEnd(c) + "<";

            */

            #endregion

            #region ComparteTo/Equals
            /*
            string nome = "Henrique";

            if (nome.Equals("Henrique", StringComparison.OrdinalIgnoreCase))
            {
                label1.Text = "Possitivo";
            }
            else
            {
                label1.Text = "Negativo";
            }

            label1.Text = nome.CompareTo("Ana").ToString();

            */

            #endregion

            #region Format
                /*
                decimal valor = 19.95m;
                int temp = 32;
             
                string texto = String.Format("O valor do produto é o {0:C2} e a temperatura é {1}", valor , temp);
                string data = String.Format("Hoje é {0:d} e são {0:t}", DateTime.Now);
                string cifrao = $"O valor do produto é o {valor:C2} e a temperatura é {temp}";

                label1.Text = cifrao; 
                */

            #endregion

        }
    }
}
