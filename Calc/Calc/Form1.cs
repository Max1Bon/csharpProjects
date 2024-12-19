using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class fCalc : Form
    {
        public fCalc()
        {
            InitializeComponent();
        }

        public static double sum(double a, double b)
        {
            return a + b;
        }

        public static double minus(double a, double b)
        {
            return a - b;
        }

        public static double mnoj(double a, double b)
        {
            return a * b;
        }

        public static double del(double a, double b)
        {
            return a / b;
        }

        public static double stepen(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double koren(double a, double b)
        {
            return Math.Pow(a, 1/b);
        }
        
        private void bPlus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(minus(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void bMnoj_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mnoj(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void bDev_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void bSqr_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(koren(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(stepen(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
        private void fCalc_Load(object sender, EventArgs e)
        {

        }

    }
}
