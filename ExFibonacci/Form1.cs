using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbSequencia.Items.Clear();
            int a = 0, b = 1;
            lsbSequencia.Items.Add(a);
            lsbSequencia.Items.Add(b);

            for (int i = 2; i < 30; i++)
            {
                int proximo = a + b;
                lsbSequencia.Items.Add(proximo);
                a = b;
                b = proximo;
            }
        }
    }

}
