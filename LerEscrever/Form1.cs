using System.Text;

namespace LerEscrever
{
    public partial class Form1 : Form
    {

        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"c:\curso\teste.txt", true, Encoding.Default);

            //writer.WriteLine(txtConteudo.Text);

            writer.Write(txtConteudo.Text);

            //writer.Flush();
            //writer.Dispose();
            writer.Close();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {

            txtConteudo.Clear();

            StreamReader reader = new StreamReader(@"c:\curso\teste.txt", Encoding.Default);

            //txtConteudo.Text = reader.ReadToEnd();

            //string linha = reader.ReadLine();

            //while (linha != null)
            //{
            //    txtConteudo.Text += linha + "\n";
            //    linha = reader.ReadLine();
            //}

            while (!reader.EndOfStream)
            {
                txtConteudo.Text += (char)reader.Read();
            }

            reader.Close();
        }

        private void btnLerBinario_Click(object sender, EventArgs e)
        {
            FileStream file = File.OpenRead(@"c:\curso\teste.txt");
            BinaryReader reader = new BinaryReader(file);

            //while (reader.BaseStream.Position != reader.BaseStream.Length)
            //{
            //    txtConteudo.Text += reader.ReadByte() + " ";
            //}

            buffer = reader.ReadBytes((int)reader.BaseStream.Length);

            foreach (byte b in buffer)
            {
                txtConteudo.Text += b + " ";
            }

            //buffer = File.ReadAllBytes(@"c:\curso\teste.txt");

            reader.Close();

        }

        private void btnEscreverBinario_Click(object sender, EventArgs e)
        {
            FileStream file = File.OpenWrite(@"c:\curso\testeNovo.txt");
            BinaryWriter writer = new BinaryWriter(file);


            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
}