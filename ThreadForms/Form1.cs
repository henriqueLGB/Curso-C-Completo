﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForms
{
    public partial class Form1 : Form
    {
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t; //ATRIBUTO THREAD

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;  
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        private void Tarefa()
        {
            while (true)
            {
                //DefinirValorPropriedade(lbResultado, "Text", DateTime.Now.Second.ToString());

                lbResultado.Invoke(new Action(() => lbResultado.Text = DateTime.Now.Second.ToString()));

            }
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            if(controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d,new object[] {controle,propriedade,valor});
            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach(PropertyInfo p in props)
                {
                    if(p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle,valor,null);
                    }
                }

            }
        }
    }
}
