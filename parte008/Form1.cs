namespace parte008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dia selecionado : " + dateTime.Value.DayOfWeek.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime atual = DateTime.Now;
            dateTime.Value = atual;
        }
    }
}