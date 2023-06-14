using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ1
{
    public partial class Form1 : Form
    {

        List<string> lista_nomes = new List<string> ();    
        List<int> lista_numeros = new List<int> ();
        Dictionary<string, double> lista_produtos = new Dictionary<string, double> ();
        Dictionary <string, string> lista_estados = new Dictionary<string, string> ();

        public Form1()
        {
            InitializeComponent();

            #region Lista de Nomes

            lista_nomes.Add("Henrique Lira");
            lista_nomes.Add("Anne");
            lista_nomes.Add("Lucas");
            lista_nomes.Add("Jorge");

            #endregion

            #region Lista de Números

            lista_numeros.Add(09);
            lista_numeros.Add(07);
            lista_numeros.Add(06);
            lista_numeros.Add(05);
            lista_numeros.Add(04);
            lista_numeros.Add(10);
            lista_numeros.Add(40);
            lista_numeros.Add(60);
            lista_numeros.Add(80);
            lista_numeros.Add(90);

            #endregion

            #region Lista Produtos

            lista_produtos.Add("Teclado USB", 50.00);
            lista_produtos.Add("Mouse", 30.00);
            lista_produtos.Add("Fone de Ouvido", 20.00);
            lista_produtos.Add("Monitor", 650.00);

            #endregion

            #region Lista Estados

            lista_estados.Add("Rio de Janeiro","Brasil");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");

            #endregion

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            //UTILIZANDO O LINQ

            //OBTER A FONTE DOS DADOS
            //CRIAR A CONSULTA
            //EXECUTAR A CONSULTA

            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;

            //foreach(int num in res)
            //{
            //    lista.Items.Add(num);
            //}

            string txtNome = txtConsulta.Text;

            IEnumerable<string> res2 = from nome in lista_nomes 
                                       where nome.StartsWith(txtNome) 
                                       select nome;

            lista.Items.AddRange(res2.ToArray());

            //foreach(string nome in res2)
            //{
            //   lista.Items.Add(nome);
            //}

        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            string txtNome = txtConsulta.Text.ToLower();

            //Operador de Filtragem, a clausula Where
            var res = from nome in lista_nomes
                      where nome.ToLower().Contains(txtNome)
                      select nome;

            lista.Items.AddRange(res.ToArray());

        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            //Operador de ordenação 
            lista.Items.Clear();

            string txtNome = txtConsulta.Text;

            //var res = from num in lista_numeros
            //          orderby num descending //ascending
            //          where num <= 10
            //          select num;

            //var res = from nome in lista_nomes 
            //          orderby nome ascending
            //          select nome;

            var res = from produto in lista_produtos
                      orderby produto.Key
                      select produto;

            foreach(KeyValuePair<string,double> item in res)
            {
                lista.Items.Add(item.Key + " R$" + item.Value);
            }

            //foreach(string num in res)
            //{
            //    lista.Items.Add(num);
            //}
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            //Operadores de Agrupamento

            lista.Items.Clear();
            txtConsulta.Text = "";

            var res = from estado in lista_estados
                      group estado by estado.Value;

            foreach(var grupo in res)
            {
                lista.Items.Add(grupo.Key);

                foreach(var estado in grupo)
                {
                    lista.Items.Add("     " + estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            //Operadores de Agragação

            lista.Items.Clear();
            txtConsulta.Text = "";
            //int cont1 = lista_nomes.Count();
            //int cont2 = (from nomes in lista_nomes 
            //            where nomes.StartsWith("H") 
            //            select nomes).Count();

            //lista.Items.Add(cont1 + " nomes.");
            //lista.Items.Add(cont2 + " nomes começado com a letra H");

            //double media1 = lista_numeros.Average();
            //lista.Items.Add(media1 + " Média dos valores da lista de números");

            //var res1 = from numeros in lista_numeros
            //           where numeros < 10
            //           select numeros;

            //double media2 = res1.Average();

            //lista.Items.Add(media2 + " Média dos valores menores que 10 da lista de números");

            //int soma = lista_numeros.Sum();
            //lista.Items.Add(soma + " Soma dos valores da lista de números");

            //var res2 = from numeros in lista_numeros
            //           where numeros < 10
            //           select numeros;

            //int soma2 = res2.Sum();
            //lista.Items.Add(soma2 + " Soma dos valores menores que 10 da lista de números");

            //Também aplicado nas consultas
            //lista.Items.Add(lista_numeros.Min() + " Valor minimo em lista números");
            //lista.Items.Add(lista_numeros.Max() + " Valor máximo em lista números");


            //Também aplicado nas consultas
            //long contador = lista_numeros.LongCount();

            //Também aplicado nas consultas
            string maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) =>
            {
                if(maior.ToString().Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });

            lista.Items.Add(maiorNome + " É o maior nome da lista");
                
        }

        private void btnOperadoresElementos_Click(object sender, EventArgs e)
        {
            //Operadores de Elementos

            lista.Items.Clear();
            txtConsulta.Text = "";

            //Também aplicado nas consultas
            //int primeiro = lista_numeros.First();
            //int primeiro = lista_numeros.FirstOrDefault();
            //lista.Items.Add(primeiro);

            //Também aplicado nas consultas
            //int ultimo = lista_numeros.Last();
            //int ultimo = lista_numeros.LastOrDefault();
            //lista.Items.Add(ultimo);

            //int elementoEm = lista_numeros.ElementAt(3);
            //lista.Items.Add(elementoEm);

            //var res1 = from numero in lista_numeros
            //           where numero > 1000
            //           select numero;

            //int num = res1.FirstOrDefault();
            //lista.Items.Add(num);
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            //Método Lambda

            lista.Items.Clear();
            txtConsulta.Text = "";

            //var consulta = lista_nomes.Select(nome => nome);
            //lista.Items.AddRange(consulta.ToArray());

            //var consulta2 = lista_nomes.Where(nomes => nomes.StartsWith("H"));
            //lista.Items.AddRange(consulta2.ToArray());

            //var consulta3 = lista_nomes.OrderBy(nomes => nomes);
            //var consulta3L = lista_nomes.OrderByDescending(nomes => nomes);
            //lista.Items.AddRange(consulta3.ToArray());

            var consult4 = lista_estados.GroupBy(estado => estado.Value);

            foreach(var grupo in consult4)
            {
                lista.Items.Add(grupo.Key);
                foreach(var estado in grupo)
                {
                    lista.Items.Add("  " + estado.Key);
                }
            }
        }
    }
}
