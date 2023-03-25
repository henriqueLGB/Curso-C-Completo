using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            #region MessageBox 
            //MessageBox.Show("Olá tudo bem ?");
            //MessageBox.Show("Mensagem a ser impressa", "Título da mensagem");
            //MessageBox.Show("Texto da Mensagem", "Título", MessageBoxButtons.YesNo);
            //DialogResult res = MessageBox.Show("Texto da Mensagem", "Título", MessageBoxButtons.YesNoCancel);

            //if (res == DialogResult.Yes)
            //{
            //    lbTexto.Text = "Clicado em sim";
            //}
            //else if (res == DialogResult.No)
            //{
            //    lbTexto.Text = "Clicado em Não";
            //}
            //else if (res == DialogResult.Cancel)
            //{
            //    lbTexto.Text = "Clicado em Cancelar";
            //}

            //MessageBox.Show("Mensagem","Título",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            MessageBox.Show("Mensagem", "Título", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            #endregion
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            #region Random 

            Random r = new Random(DateTime.Now.Millisecond);

            int n  = r.Next(100);
            double n2 = r.NextDouble() * 100;

            lbTexto.Text = "Número: " + n2.ToString();    

            #endregion
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            #region TimeSpan

            //lbTexto.Text = TimeSpan.FromMinutes(60).ToString();
            //lbTexto.Text = TimeSpan.FromDays(90).ToString();
            //lbTexto.Text = TimeSpan.FromTicks(100000).ToString();
            //lbTexto.Text = TimeSpan.TicksPerMinute.ToString();

            TimeSpan inicio     = new TimeSpan(5,30,30); // H| M | S
            TimeSpan fim        = new TimeSpan(18, 25, 00);

            //TimeSpan intervalo  = fim - inicio;
            //TimeSpan intervalo = fim + inicio;

            //TimeSpan intervalo  = inicio.Add(fim);
            TimeSpan intervalo = fim.Subtract(inicio);

            lbTexto.Text = intervalo.ToString();

            #endregion
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            #region DateTime

            //lbTexto.Text = DateTime.Now.ToString();
            //lbTexto.Text = DateTime.Today.ToString();
            //lbTexto.Text = DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month).ToString();
            //lbTexto.Text = DateTime.IsLeapYear(DateTime.Now.Year).ToString();
            //lbTexto.Text = DateTime.Now.ToLongDateString();
            //lbTexto.Text = DateTime.Now.ToShortDateString();
            //lbTexto.Text = DateTime.Now.ToLongTimeString();
            //lbTexto.Text = DateTime.Now.ToUniversalTime().ToString();

            //lbTexto.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime data = new DateTime(1945,02,15,14,35,20);

            ////lbTexto.Text = data.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lbTexto.Text = data.Add(tempo).ToString();

            //lbTexto.Text = data.DayOfWeek.ToString();

            lbTexto.Text = data.DayOfYear.ToString();

            #endregion
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            #region Color

            Color vermelho = Color.Red;
            Color amarelo = Color.Yellow;

            Color cor1 = Color.FromArgb(255,Color.DarkGreen);
            Color cor2 = Color.FromKnownColor(KnownColor.Control);
            Color cor3 = Color.FromName("DarkRed");


            lbTexto.BackColor = cor3;
            lbTexto.ForeColor = cor1;

            Color cor4 = lbTexto.BackColor;

            btnColor.ForeColor = cor4;

            #endregion
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            #region Font

            Font letra  = new Font("Helvetica,Arial,sans-serif", 36, FontStyle.Regular, GraphicsUnit.Pixel);
            Font letra2 = new Font(FontFamily.GenericMonospace,36,FontStyle.Regular, GraphicsUnit.Pixel);

            lbTexto.Text = "Bem vindo ao C#, trabalhando com fonte";
            lbTexto.Font = letra2;

            #endregion
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            #region Environment

            string pathDoc      = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dirAtual     = Environment.CurrentDirectory;
            string varAmb       = Environment.GetEnvironmentVariable("Path");
            string[] discos     = Environment.GetLogicalDrives();
            string user         = Environment.UserName;
            string dominio      = Environment.UserDomainName;
            int cpu             = Environment.ProcessorCount;
            //Environment.NewLine

            //foreach (string item in discos)
            //{
            //    lbTexto.Text += "\n" + item;
            //}

            lbTexto.Text = cpu.ToString();

            #endregion
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            #region Application

            //Application.Exit();

            string exec  = Application.ExecutablePath;
            string pasta = Application.StartupPath;

            //Application.Restart();

            lbTexto.Text = pasta;

            #endregion
        }

    }
}
