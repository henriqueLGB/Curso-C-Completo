namespace parte010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //lista.Columns.Add("ID");

            ListViewItem item1 = new ListViewItem("01");
            item1.SubItems.Add("Henrique Lira");
            item1.SubItems.Add("443.074.198-04");
            item1.SubItems.Add("44.698.456.98-8");

            ListViewItem item2 = new ListViewItem("02");
            item2.SubItems.Add("José Lira");
            item2.SubItems.Add("443.074.198-04");
            item2.SubItems.Add("44.698.456.98-8");

            ListViewItem item3 = new ListViewItem("03");
            item3.SubItems.Add("Ana Mariana");
            item3.SubItems.Add("443.074.198-04");
            item3.SubItems.Add("44.698.456.98-8");

            ListViewItem item4 = new ListViewItem(new string[] { "04", "Arthur", "456.987.568-08", "56.987.599.56-8" });

            lista.Items.Add(item1);
            lista.Items.Add(item2);
            lista.Items.Add(item3);
            lista.Items.Add(item4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lista.Items.Clear();
            //lista.Items.Remove(lista.SelectedItems[0]);
            lista.Items.RemoveAt(1);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(lista.SelectedItems[0].Text);
        }
    }
}