namespace parte007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combo.Items.Add("São Paulo");
            combo.Items.Add("Rio de Janeiro");
            combo.Items.Add("Minas Gerais");

            combo.Items.AddRange(new Object[] { "Paraíba", "Pernambuco" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(combo.Items.Count.ToString());
            //object item = combo.SelectedItem;
            //int indice = combo.SelectedIndex;

            //MessageBox.Show(indice + " " + item);

            //combo.Items.Clear();

            //combo.Items.Remove("São Paulo");
            //combo.Items.RemoveAt(1);

            //combo.Items.Insert(0, "Ceara");

            //MessageBox.Show(combo.Items.IndexOf("São Paulo").ToString());
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(combo.SelectedItem.ToString());
        }
    }
}