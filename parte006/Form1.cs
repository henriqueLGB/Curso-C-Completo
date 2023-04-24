namespace parte006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkList.Items.Add("Carro", true);
            checkList.Items.Add("Moto");
            checkList.Items.Add("Onibus");
            checkList.Items.Add("Avião");

            int qtdeItems = checkList.Items.Count;
            //MessageBox.Show("Quantidade items " + qtdeItems);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkList.Items.Clear();    

            //checkList.Items.AddRange(new Object[] { "Bike" , "Mobilete" , "Caminhão"});

            //bool res = checkList.Items.Contains("Carro");

            //if (res)
            //{
            //    MessageBox.Show("Contém");
            //}

            //checkList.Items.Remove("Moto");
            //checkList.Items.RemoveAt(2);

            //checkList.Items.Insert(1, "Carroça");

            //var items = checkList.CheckedItems;

            //foreach(var item in items )
            //{
            //    MessageBox.Show(item.ToString());
            //}

            //var items = checkList.SelectedItems;

            //foreach (var item in items)
            //{
            //    MessageBox.Show(item.ToString());
            //}



        }

        private void checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkList.SelectedItem.ToString();
        }
    }
}