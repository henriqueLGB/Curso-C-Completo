using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            #region LIST
         
            lista.Items.Clear(); //LIMPAR O LISTBOX

            //Array
            string[] nomes1 = new string[3];
            nomes1[0] = "Josefina";
            nomes1[1] = "Carlos";
            nomes1[2] = "Flávio";
                 
            List<string> nomes = new List<string>();
            nomes.Add("Henrique");
            nomes.Add("Lucas");
            nomes.Add("José");

            if (nomes.Remove("Lucas"))
            {
                MessageBox.Show("Lucas removido !");
            }
            else
            {
                MessageBox.Show("Não foi possível remover !");
            }

            if (nomes1.Contains("Henrique"))
            {
                MessageBox.Show("Contém!");
            }
            else
            {
                MessageBox.Show("Não contém !");
            }

            nomes.AddRange(nomes1); //ADICIONA UM ARRAY DENTRO DA LISTA (LEMBRANDO QUE OS ITENS DO ARRAY DEVE SER STRING


            //MessageBox.Show("Número de elementos " + nomes1.Count());

            //nomes.Sort(); //ORDENA A LISTA

            //MessageBox.Show("O Henrique está no indice: " + nomes.IndexOf("Henrique"));

            //nomes.Insert(0, "João"); //ADICIONA UM DETERMINADO DADO EM UMA DETERMINADA POSIÇÃO DO INDICE

            //nomes.RemoveAt(0); //REMOVE ATRAVÉS DA POSIÇÃO DA LISTA

            //nomes.Clear(); //LIMPA TODA A LISTA 

            foreach (string item in nomes)
            {
                lista.Items.Add(item);
            }
            
            #endregion
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro",
                "Moto",
                "Avião",
                "Helicoptero",
                "Barco" 
            };

            //MessageBox.Show(veiculos.ElementAt(2));

            //MessageBox.Show(veiculos.First());

            //MessageBox.Show(veiculos.Last());

            //veiculos.Remove("");
            //veiculos.Count();
            //veiculos.Clear();
            //veiculos.Contains("");

            /*if (veiculos.Add("Moto"))
            {
                MessageBox.Show("Item adicionado !");
            }
            else
            {
                MessageBox.Show("Item não adicionado !");
            }


            if (veiculos.Contains("Carro"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");
            }*/

            foreach (string item in veiculos) 
            {
                lista.Items.Add(item);
            }

        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Dictionary<int, string> alunos= new Dictionary<int, string>()
            {
                {50,    "Lucas" },
                {90,    "José" },
                {80,    "Lucas" }
            };

            alunos.Add(100,"Henrique");
            //alunos.Remove(80);

            //alunos.Clear();

            //MessageBox.Show("Primeiro: " + alunos.First().Value);
            //MessageBox.Show("último: " + alunos.First().Value);

            /*if (alunos.ContainsKey(80))
            {
                MessageBox.Show("Contém !");
            }
            else
            {
                MessageBox.Show("Não Contém !");
            }*/

            /*if (alunos.ContainsValue("Henrique"))
            {
                MessageBox.Show("Contém !");
            }
            else
            {
                MessageBox.Show("Não Contém !");
            }*/



            foreach (KeyValuePair<int,string> item in alunos)
            {
                lista.Items.Add("Matricula: " + item.Key + " Nome: " + item.Value);
            }

            //MessageBox.Show("Quantidade de Alunos : " + alunos.Count());

        }

        private void btnSortedList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();    

            SortedList<int,string> funcionarios = new SortedList<int, string>()
            {
                {27,"Henrique" },
                {10, "Gabriel" },
                {17, "Arthur" }
            };


            funcionarios.Add(100, "José");

            //funcionarios.Remove(10);
            //funcionarios.RemoveAt(0);

            //funcionarios.Count();

            //funcionarios.ContainsKey(10);
            //funcionarios.ContainsValue("Henrique");

            foreach(KeyValuePair<int,string> item in funcionarios)  //funcionarios.Reverse()
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }


        }

        private void btnSortedDictionary_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();    

            SortedDictionary<int, string> pessoas = new SortedDictionary<int, string>()
            {
                {312312 , "Lucas" },
                {4342432, "Henrique" },
                {454545, "Arthur" },
                {42342, "Daniela" }
            };

            pessoas.Add(1000, "José");

            //pessoas.Remove(1000);
            //pessoas.Count();
            //pessoas.Clear();

            //pessoas.ContainsKey(1000);
            //pessoas.ContainsValue("José");

            //
            //pessoas.ElementAt(0);

            foreach(KeyValuePair<int,string> item in pessoas) //pessoas.Reverse()
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }

        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            SortedSet<string> nomes = new SortedSet<string>
            {
                "Gabriel" , "Lucas" , "Luciano" , "José" , "Henrique"
            };

            if (!nomes.Add("Lucas"))
            {
                MessageBox.Show("Não pode adicionar esse valor");
            }

            //nomes.Reverse();
            //nome.Remove("Lucas");
            //nomes.ElementAt(1);
            //nomes.First();
            //nomes.Last();
            //nomes.Count();
            //nomes.Clear();

            foreach(string nome in nomes)
            {
                lista.Items.Add(nome);
            }

        }

        private void btnQueue_Click(object sender, EventArgs e)
        {

            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Henrique");
            fila.Enqueue("Gabriel");
            fila.Enqueue("Arthur");

            //fila.First();
            //fila.Last();

           
            while(fila.Count > 0) 
            {

                MessageBox.Show("Primeiro da fila : " + fila.Dequeue());
                MessageBox.Show(fila.Count().ToString());

                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);
                }
            }


            //MessageBox.Show("Primeiro da fila : " + fila.Peek());
            //MessageBox.Show(fila.Count().ToString());


            //LISTA O PRIMEIRO DA FILA E REMOVE
            //MessageBox.Show("Primeiro da fila : " + fila.Dequeue());
            //MessageBox.Show(fila.Count().ToString());

        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("Henrique");
            pilha.Push("Ana");
            pilha.Push("Lucas");
            pilha.Push("Arthur");

            //MessageBox.Show(pilha.Count().ToString());

            //MessageBox.Show("Elemento do Topo: " + pilha.Peek());
            //MessageBox.Show(pilha.Count().ToString());

            while(pilha.Count() > 0)
            {
                MessageBox.Show("Elemento do Topo: " + pilha.Pop());
                MessageBox.Show(pilha.Count().ToString());

                lista.Items.Clear();

                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }

            }

        }
    }
}
