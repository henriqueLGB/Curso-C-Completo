namespace Diretorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\curso";

            bool res = Directory.Exists(path + "logan");

            listBox1.Items.Clear();

            //listBox1.Items.Add(res);

            //if(!res)
            //{
            //    Directory.CreateDirectory(path + "logan");
            //    MessageBox.Show("Pasta criada");
            //}

            //if (res)
            //{
            //    Directory.Delete(path + "logan");
            //    MessageBox.Show("Pasta deletada");
            //}

            //if (res)
            //{
            //    Directory.Move(path + "logan", path + "Destino");
            //}


            //string[] dirs = Directory.GetDirectories(@"c:\");

            //foreach(string dir in dirs)
            //{
            //    listBox1.Items.Add(dir);    
            //}

            //string[] files = Directory.GetFiles(@"c:\IdentityV");

            //foreach (string file in files)
            //{
            //    listBox1.Items.Add(file);
            //}

            //string root = Directory.GetDirectoryRoot(path);
            //listBox1.Items.Add(root);

            //string[] drives = Directory.GetLogicalDrives();
            //listBox1.Items.AddRange(drives);

            //DirectoryInfo info = Directory.GetParent(path);
            //listBox1.Items.Add(info.FullName);

            //string dir = Directory.GetCurrentDirectory();
            //listBox1.Items.Add(dir);
        }
    }
}