using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            //Folha em Branco
            Bitmap folha = new Bitmap(pictureBox.Width,pictureBox.Height);

            //Criar desenhador
            Graphics desenhador = Graphics.FromImage(folha);

            //Desenhar na folha
            desenhador.Clear(Color.White);

            #region Linhas 

            //Brush pincel1 = new SolidBrush(Color.Red);

            //Pen lapis1 = new Pen(pincel1,5);

            //Point ponto1 = new Point(100, 200);
            //Point ponto2 = new Point(400, 100);

            //Pen lapis2 = new Pen(Color.Black, 10);

            //Point ponto3 = new Point(0,0);
            //Point ponto4 = new Point(100, 200);

            ////desenhador.DrawLine(lapis1,ponto1,ponto2);
            ////desenhador.DrawLine(lapis2, ponto3, ponto4);
            //Point[] pontos =
            //{
            //    new Point(50,50),
            //    new Point(250,50),
            //    new Point(250,150),
            //    new Point(100,80),
            //    new Point(85,140),
            //};

            //desenhador.DrawLines(lapis1,pontos);

            #endregion

            #region Retangulos

            //Pen lapis1 = new Pen(Color.Black,5);
            //Pen lapis2 = new Pen(Color.Blue, 10);

            //Rectangle rect1 = new Rectangle(100,50,300,200);
            //Rectangle rect2 = new Rectangle(50, 850, 120, 40);
            //Rectangle rect3 = new Rectangle(120, 20, 145, 100);
            //Rectangle rect4 = new Rectangle(75, 200, 250, 100);

            //desenhador.DrawRectangle(lapis1,rect1);
            //desenhador.DrawRectangle(lapis2, 0,0,150,150);

            //Rectangle[] retangulos =
            //{
            //    rect1,rect2,rect3,rect4, new Rectangle(10,30,240,85)
            //};

            ////desenhador.DrawRectangles(lapis1, retangulos);
            //Brush pincel1 = new SolidBrush(Color.Green);
            //Brush pincel2 = new LinearGradientBrush(rect4,Color.Green,Color.Yellow,90);

            //desenhador.FillRectangle(pincel2,rect4);

            //desenhador.FillRectangles(pincel2,retangulos);

            #endregion

            #region Ellipse e Circulos  

            //Pen lapis1 = new Pen(Color.Black, 5);
            //Rectangle rect1 = new Rectangle(50,50,150,150);

            ////desenhador.DrawRectangle(lapis1, rect1);
            //desenhador.DrawEllipse(lapis1,rect1);

            //Brush pincel = new SolidBrush(Color.Yellow);

            //desenhador.FillEllipse(Brushes.Gray, rect1);

            #endregion

            #region Poligonos

            //Pen lapis = new Pen(Color.Black, 5);

            //Point[] pontos = 
            //{
            //    new Point(100, 100),
            //    new Point(300, 200),
            //    new Point(250,250),
            //    new Point(100,200)
            //};

            ////desenhador.DrawPolygon(lapis,pontos);
            //Brush pincel = new LinearGradientBrush(new Rectangle(100, 100, 200, 200), Color.Red, Color.Yellow, 45);
            //desenhador.FillPolygon(pincel, pontos);

            #endregion

            #region Curvas 

            //Pen lapis = new Pen(Color.Black, 5);

            //Point[] pontos =
            //{
            //    new Point(100, 100),
            //    new Point(300, 200),
            //    new Point(250,250),
            //    new Point(100,200)
            //};

            ////desenhador.DrawCurve(lapis, pontos,3);
            ////desenhador.DrawClosedCurve(lapis, pontos, 1.5f ,FillMode.Alternate);
            //desenhador.FillClosedCurve(Brushes.Red, pontos, FillMode.Winding,1.5f);

            #endregion

            #region Arcos

            //Pen lapis = new Pen(Color.Black, 5);

            //Rectangle rect = new Rectangle(100,100,300,250);

            //desenhador.DrawArc(lapis,rect,45f,270f);

            #endregion

            #region Beziers

            //Pen lapis = new Pen(Color.Black,5);

            //Point ponto1 = new Point(50,300);
            //Point ponto2 = new Point(200, 400);
            //Point ponto3 = new Point(400, 100);
            //Point ponto4 = new Point(500, 200);

            //desenhador.DrawBezier(lapis,ponto1,ponto2,ponto3,ponto4);

            //Point[] pontos =
            //{
            //    new Point(50,300),//Ínicio
            //    new Point(150, 350),
            //    new Point(300, 100),
            //    new Point(400, 150), //Meio
            //    new Point(500, 400),
            //    new Point(300, 10),
            //    new Point(500, 100), //Fim
            //};

            //desenhador.DrawBeziers(lapis,pontos);

            #endregion

            #region Pie

            //Pen lapis        = new Pen(Color.Black, 5);
            //Rectangle rect1  = new Rectangle(50,50,250,250);

            //desenhador.DrawPie(lapis,rect1,45,45);
            //desenhador.FillPie(Brushes.Black,rect1,270,90);

            #endregion

            #region Path

            //Pen lapis = new Pen(Color.Black, 5);
            //GraphicsPath path = new GraphicsPath(FillMode.Alternate);

            //path.AddEllipse(new RectangleF(10,10,100,150));
            //path.AddEllipse(new RectangleF(50, 10, 100, 150));
            //path.AddRectangle(new RectangleF(150, 15, 150, 100));

            //desenhador.DrawPath(lapis,path);
            //desenhador.FillPath(Brushes.Black,path);    
            #endregion

            #region Strings

            //string texto = "Henrique Lira";
            //Font letra = new Font("Arial",28,FontStyle.Bold,GraphicsUnit.Point);
            //Point ponto = new Point(50,100);
            //Brush pincel = new LinearGradientBrush(new Rectangle(0,0,400,400),Color.Yellow,Color.Red,45);
            //Rectangle rect = new Rectangle(10, 20, 500, 400);
            //StringFormat alinhamento = new StringFormat();
            ////desenhador.DrawString(texto,letra,pincel,ponto);
            ////desenhador.DrawString(texto,letra, pincel, rect);

            //alinhamento.Alignment = StringAlignment.Center; 
            //alinhamento.LineAlignment = StringAlignment.Center;
            //alinhamento.FormatFlags = StringFormatFlags.NoWrap;

            //desenhador.DrawString(texto,letra,pincel,rect,alinhamento);

            #endregion

            #region Imagens

            //Image imgOrigem1    = Image.FromFile(Application.StartupPath + @"\Imagens\mage.jpg");
            //Rectangle origem1   = new Rectangle(0,0,imgOrigem1.Width,imgOrigem1.Height);
            //Rectangle destino1  = new Rectangle(100, 50, imgOrigem1.Width / 2, imgOrigem1.Height / 2);


            //Image imgOrigem2 = Image.FromFile(Application.StartupPath + @"\Imagens\imperador.jpg");
            //Rectangle origem2 = new Rectangle(40, 25, 150, 200);
            //Rectangle destino2 = new Rectangle(170, 170, 150, 200);

            //desenhador.DrawImage(imgOrigem1,destino1,origem1, GraphicsUnit.Pixel);
            //desenhador.DrawImage(imgOrigem2, destino2, origem2, GraphicsUnit.Pixel);

            #endregion

            //Utilizar num PictureBox
            pictureBox.BackgroundImage = folha;

            //Salvar o desenho em um diretório
            //folha.Save(@"C:\Users\henri\Downloads\imagem.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
