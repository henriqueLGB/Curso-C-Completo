using System.IO;
using System.Text;

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string pasta    = @"c:\curso\";
            string arquivo  = "teste.txt";

            //bool res = File.Exists(pasta + arquivo);
            //label1.Text = res.ToString();

            //File.Delete(pasta + arquivo);
            //File.Create(pasta + arquivo).Close();

            //if(!File.Exists(pasta + arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    label1.Text = "Arquivo Criado !";
            //}
            //else
            //{
            //    label1.Text = "Arquivo já existe !";
            //}

            //if(File.Exists(pasta + arquivo)) 
            //{
            //    File.Copy(pasta + arquivo,pasta + "Copia.txt",true);
            //    label1.Text = "Copiado !";
            //}
            //else
            //{
            //    label1.Text = "Arquivo não existe !";
            //}

            //File.Move(pasta + arquivo, pasta + "Movido.txt");

            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo",Encoding.Default);
            //label1.Text = File.ReadAllText(pasta + arquivo);
            //label1.Text = File.GetCreationTime(pasta + arquivo,DateTime.Now).ToString();

            //File.SetCreationTime(pasta + arquivo, DateTime.Now);
        }
    }
}