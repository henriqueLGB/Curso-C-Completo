using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int altura;
        int largura;
        int numLinhas;
        int pagina;
        int numPaginas;

        public Form1()
        {
            InitializeComponent();
            pagina     = 0;
            numPaginas = 0;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region parte 1

            //string texto        = "Trabalhando com a impressão ";
            //Font letra          = new Font("Arial",20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel        = new SolidBrush(Color.Black);
            //Point pontoInicial  = new Point(100,50);

            ////Desenhar o documento para ser impresso
            //e.Graphics.DrawString(texto,letra,pincel,pontoInicial);
            //e.Graphics.DrawString("Henrique Lira", letra, pincel, new Point(100,150));
            //e.Graphics.FillRectangle(Brushes.Green,new RectangleF(100,220,400,100));

            #endregion

            #region parte 2

            //x = printDocument1.DefaultPageSettings.Bounds.X;
            //y = printDocument1.DefaultPageSettings.Bounds.Y;
            //altura = printDocument1.DefaultPageSettings.Bounds.Width;
            //largura = printDocument1.DefaultPageSettings.Bounds.Height;


            //string titulo = "Título da Página ";
            //Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            //Brush pincelTitulo = new SolidBrush(Color.Red);
            //Rectangle areaTitulo = new Rectangle(x + 50, y + 100, largura - 100, 100);
            //StringFormat formatoTitulo = new StringFormat();
            //formatoTitulo.Alignment = StringAlignment.Center;
            //formatoTitulo.LineAlignment = StringAlignment.Center;

            //string texto = "Trabalhando com a impressão ";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Rectangle areaTexto = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

            ////Desenhar o documento para ser impresso
            //e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo,formatoTitulo);
            //e.Graphics.DrawString(texto, letra, pincel, areaTexto);

            #endregion

            #region parte 3

            List<string> linhas = new List<string>()
            {
                "1. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                "2. Lorem ipsum dolor sit amet, consectetur adipiscing elit 2.",
                "3. Lorem ipsum dolor sit amet, consectetur adipiscing elit 3.",
                "4. Lorem ipsum dolor sit amet, consectetur adipiscing elit 4.",
                "5. Lorem ipsum dolor sit amet, consectetur adipiscing elit 5.",
                "6. Lorem ipsum dolor sit amet, consectetur adipiscing elit.6",
            };

            string titulo = "Título da Página ";
            Font letraTitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Red);
            Rectangle areaTitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);


            while (numLinhas < linhas.Count())
            {

                if (numLinhas == 0)
                {
                    //Impressão do título
                    e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTitulo, formatoTitulo);
                    y += 150;
                }

                e.Graphics.DrawString(linhas[numLinhas], letra, pincel, new Point(x, y));
                y += 30;
                numLinhas++;

                if (y >= altura - 50)
                {
                    //Mudar de página
                    y = 50;
                    e.HasMorePages = true;
                    numPaginas++;
                    break;
                }
            }

            #endregion



        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            altura = printDocument1.DefaultPageSettings.Bounds.Width;
            largura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            numLinhas = 0;

            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                altura = printDocument1.DefaultPageSettings.Bounds.Width;
                largura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            altura = printDocument1.DefaultPageSettings.Bounds.Width;
            largura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            numLinhas = 0;

            printPreviewControl1.Document = printDocument1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(pagina > 0)
            {
                printPreviewControl1.StartPage = - -pagina;
            }
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (pagina < numPaginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnVisualizarPadrao_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
