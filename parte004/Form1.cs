namespace parte004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            lista.Items.Add(nome);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            object item = lista.SelectedItem;
            lista.Items.Remove(item);
        }

        private void btnRemoverIndice_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            lista.Items.RemoveAt(indice);
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lista.SelectedItem.ToString();
            txtNome.Text = nome;
        }

        private void btnQuantidadesItens_Click(object sender, EventArgs e)
        {
            int qtdeItens = lista.Items.Count;
            MessageBox.Show("Quantidade de items da Lista " + qtdeItens);
        }
    }
}