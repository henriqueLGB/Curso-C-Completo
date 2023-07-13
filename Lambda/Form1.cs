using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ////Expressão lambda que tem uma expressão como corpo:
            ////(input - parameters) => expression

            ////Instrução lambda que tem um bloco de instrução como corpo:
            ////(input - parameters) => {<sequence - of - statements > }

            ////Func<int, int> square = quadrado;

            //Func<int, int> square = x => x * x;

            ////lbResultado.Text = "O resultado é : " + square(5);

            //Expression<Func<int,int>> ex = x => x * x;

            ////lbResultado.Text = ex.ToString();

            //int[] numeros = { 2, 3, 4, 5, 6, 7 };
            //var squareNumeros = numeros.Select(x => x * x);
            //lbResultado.Text = String.Join(",", squareNumeros);

            //Action<string> greet = name =>
            //{
            //    string greeting = $"Hello {name}";
            //    lbResultado.Text = greeting;    
            //};

            //greet("Henrique Lira");

            //Action line = () => Console.WriteLine();

            //Console.WriteLine("Henrique");
            //line();
            //Console.WriteLine("Lira");

            Func<int, int, bool> testeFor = (x, y) => x == y;
            lbResultado.Text = testeFor(10, 10).ToString();
        }


        int quadrado(int x)
        {
            return x * x;
        }
    }
}
