namespace DirInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"c:\curso");
            listBox1.Items.Clear();
            listBox1.Items.Add(info.FullName);
            listBox1.Items.Add(info.Parent);
            listBox1.Items.Add(info.Name);
            listBox1.Items.Add(info.CreationTime);
            listBox1.Items.Add(info.Exists);
            listBox1.Items.Add(info.Root);
            listBox1.Items.Add("-------------------------");

            DirectoryInfo[] dirs = info.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                listBox1.Items.Add(dir.FullName);
            }

            listBox1.Items.Add("-------------------------");

            FileInfo[] files = info.GetFiles();
            foreach (FileInfo file in files) 
            {
                listBox1.Items.Add(file.Name);
            }
        }
    }
}