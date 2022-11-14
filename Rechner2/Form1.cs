using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechner2
{
    public partial class Form1 : Form
    {

        IRechner rechnen;
        public Form1()
        {
            InitializeComponent();
            rechnen = new Rechnen();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double sum = rechnen.Plus((double)zahl1.Value, (double)zahl2.Value);
            MessageBox.Show("SUM:" + sum);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double minus = rechnen.Minus((double)zahl1.Value, (double)zahl2.Value);
            MessageBox.Show("MINUS:" + minus);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (EingabeTest())
            {
                double divide = rechnen.Divide((double)zahl1.Value, (double)zahl2.Value);
                MessageBox.Show("DIVIDE:" + divide);
            }  
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            double multiple = rechnen.Multiple((double)zahl1.Value, (double)zahl2.Value);
            MessageBox.Show("MULTIPLE:" + multiple);
        }

        bool EingabeTest()
        {
            bool eingabe2 = true;
            if (zahl2.Value == 0)
            {
                eingabe2 = false;
                MessageBox.Show("0 ist nicht gültig");
            }

            return eingabe2;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void zahl3_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
