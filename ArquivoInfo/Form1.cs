namespace ArquivoInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(@"c:\curso\teste.txt");
            
            if(info.Exists )
            {

                lista.Items.Clear();
                lista.Items.Add(info.FullName);
                lista.Items.Add(info.Name);
                lista.Items.Add(info.Extension);
                lista.Items.Add(info.Directory.FullName);
                lista.Items.Add(info.DirectoryName);
                lista.Items.Add(info.CreationTime);
                lista.Items.Add(info.Length);
                lista.Items.Add(info.Exists);
                lista.Items.Add(info.LastAccessTime);
            }
            else
            {
                MessageBox.Show("Arquivo Não existe !");
            }

        }
    }
}