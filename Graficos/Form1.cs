using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {

        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1()
        {
            InitializeComponent();
            valores = new Dictionary<double, double> ();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtValorX.Focus();

            for(int i = 0; i < 35; i++)
            {
                tipoGrafico.Items.Add((SeriesChartType)i);
            }

            for (int i = 0; i < 13; i++)
            {
                palletCor.Items.Add((ChartColorPalette)i);
            }

        }

        private void btnInserirValores_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtValorX.Text) || String.IsNullOrEmpty(txtValorY.Text))
            {
                MessageBox.Show("Os dois valores são obrigatórios");
                return;
            }

            if (valores.ContainsKey(double.Parse(txtValorX.Text)))
            {
                valores[double.Parse(txtValorX.Text)] = double.Parse(txtValorY.Text);
            }
            else
            {
                valores.Add(double.Parse(txtValorX.Text), double.Parse(txtValorY.Text));
            }

            dataValores.Rows.Clear();
            grafico.Series[0].Points.Clear();

            var items = from valor in valores orderby valor.Key ascending select valor;

            foreach (var item in items)
            {
                dataValores.Rows.Add(item.Key, item.Value);
                grafico.Series[0].Points.AddXY(item.Key, item.Value);
            }

            grafico.Update();

            txtValorX.Text = "";
            txtValorY.Text = "";
            txtValorX.Focus();

        }

        private void dataValores_SelectionChanged(object sender, EventArgs e)
        {
            txtValorX.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[0].Value.ToString();
            txtValorY.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnLimparGrafico_Click(object sender, EventArgs e)
        {
            valores.Clear();
            grafico.Series[0].Points.Clear();
            dataValores.Rows.Clear();
            contadorX = 0;
            txtValorX.Text = "";
            txtValorY.Text = "";
            txtValorX.Focus();
        }

        private void tipoGrafico_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Series[0].ChartType = (SeriesChartType)tipoGrafico.SelectedIndex;
        }

        private void palletCor_SelectedIndexChanged(object sender, EventArgs e)
        {
            grafico.Palette = (ChartColorPalette)palletCor.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            grafico.ChartAreas[0].Area3DStyle.Enable3D = checkBox1.Checked;
        }

        private void btnInserirValoresAleatorios_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void txtValorX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (txtValorX.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void txtValorY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44) || (txtValorY.Text.Contains((char)44) && e.KeyChar == (char)44))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (grafico.Series[0].Points.Count() > 10)
            {
                grafico.Series[0].Points.RemoveAt(0);
                grafico.Update();
            }

            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);

            grafico.Series[0].Points.AddXY(contadorX++, y);
            dataValores.Rows.Add(contadorX, y);
            dataValores.CurrentCell = dataValores.Rows[dataValores.Rows.Count - 1].Cells[0];
        }
    }
}
