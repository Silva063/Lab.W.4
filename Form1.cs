using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW4._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double x0 = double.Parse(textBox1.Text);
          //  textBox5.Text += Environment.NewLine + "x0=" + x0.ToString();
            double xk = double.Parse(textBox2.Text);
          //  textBox5.Text += Environment.NewLine + "xk=" + xk.ToString();
            double dx = double.Parse(textBox3.Text);
          //  textBox5.Text += Environment.NewLine + "dx=" + dx.ToString();
            double b = double.Parse(textBox4.Text);
            //  textBox5.Text += Environment.NewLine + "b=" + b.ToString();

            double i = x0;
           while (Math.Abs(i)<Math.Abs(xk))
            {
                double y = (Math.Pow(Math.Abs(i - b), 1d / 2d)) / (Math.Pow(Math.Abs(Math.Pow(b, 3) - Math.Pow(i, 3)), 3d / 2d)) + Math.Log(Math.Abs(i - b));
                textBox5.Text += "x=" + Convert.ToString(i) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                i += dx;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-0,73";
            textBox2.Text = "-1,73";
            textBox3.Text = "-0,1";
            textBox4.Text = "-2,0";
        }
    }
}
