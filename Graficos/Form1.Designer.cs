namespace Graficos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtValorX = new System.Windows.Forms.TextBox();
            this.txtValorY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.btnLimparGrafico = new System.Windows.Forms.Button();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.palletCor = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnInserirValoresAleatorios = new System.Windows.Forms.Button();
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.EixoX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EixoY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValorX
            // 
            this.txtValorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorX.Location = new System.Drawing.Point(14, 98);
            this.txtValorX.Name = "txtValorX";
            this.txtValorX.Size = new System.Drawing.Size(164, 35);
            this.txtValorX.TabIndex = 1;
            this.txtValorX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorX_KeyPress);
            // 
            // txtValorY
            // 
            this.txtValorY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorY.Location = new System.Drawing.Point(202, 98);
            this.txtValorY.Name = "txtValorY";
            this.txtValorY.Size = new System.Drawing.Size(153, 35);
            this.txtValorY.TabIndex = 2;
            this.txtValorY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorY_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor de X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gráfico";
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.Location = new System.Drawing.Point(14, 139);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(341, 44);
            this.btnInserirValores.TabIndex = 6;
            this.btnInserirValores.Text = "Inserir Valores no gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = true;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // btnLimparGrafico
            // 
            this.btnLimparGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparGrafico.Location = new System.Drawing.Point(14, 345);
            this.btnLimparGrafico.Name = "btnLimparGrafico";
            this.btnLimparGrafico.Size = new System.Drawing.Size(341, 44);
            this.btnLimparGrafico.TabIndex = 7;
            this.btnLimparGrafico.Text = "Limpar Gráfico";
            this.btnLimparGrafico.UseVisualStyleBackColor = true;
            this.btnLimparGrafico.Click += new System.EventHandler(this.btnLimparGrafico_Click);
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(12, 408);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(249, 21);
            this.tipoGrafico.TabIndex = 8;
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // palletCor
            // 
            this.palletCor.FormattingEnabled = true;
            this.palletCor.Location = new System.Drawing.Point(267, 408);
            this.palletCor.Name = "palletCor";
            this.palletCor.Size = new System.Drawing.Size(247, 21);
            this.palletCor.TabIndex = 9;
            this.palletCor.SelectedIndexChanged += new System.EventHandler(this.palletCor_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(520, 410);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Gráfico 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnInserirValoresAleatorios
            // 
            this.btnInserirValoresAleatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValoresAleatorios.Location = new System.Drawing.Point(631, 400);
            this.btnInserirValoresAleatorios.Name = "btnInserirValoresAleatorios";
            this.btnInserirValoresAleatorios.Size = new System.Drawing.Size(157, 34);
            this.btnInserirValoresAleatorios.TabIndex = 11;
            this.btnInserirValoresAleatorios.Text = "Inserir Valores Aleatórios";
            this.btnInserirValoresAleatorios.UseVisualStyleBackColor = true;
            this.btnInserirValoresAleatorios.Click += new System.EventHandler(this.btnInserirValoresAleatorios_Click);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EixoX,
            this.EixoY});
            this.dataValores.Location = new System.Drawing.Point(12, 189);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(341, 150);
            this.dataValores.TabIndex = 12;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
            // 
            // EixoX
            // 
            this.EixoX.HeaderText = "Eixo X";
            this.EixoX.Name = "EixoX";
            this.EixoX.ReadOnly = true;
            // 
            // EixoY
            // 
            this.EixoY.HeaderText = "Eixo Y";
            this.EixoY.Name = "EixoY";
            this.EixoY.ReadOnly = true;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(386, 98);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "X vs Y";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(402, 291);
            this.grafico.TabIndex = 13;
            this.grafico.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.dataValores);
            this.Controls.Add(this.btnInserirValoresAleatorios);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.palletCor);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.btnLimparGrafico);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorY);
            this.Controls.Add(this.txtValorX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValorX;
        private System.Windows.Forms.TextBox txtValorY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.Button btnLimparGrafico;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.ComboBox palletCor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnInserirValoresAleatorios;
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn EixoX;
        private System.Windows.Forms.DataGridViewTextBoxColumn EixoY;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer1;
    }
}

