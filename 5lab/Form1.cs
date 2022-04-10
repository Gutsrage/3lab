using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double func(double x)
        {
            if (radioButton1.Checked)
            {
                return Math.Sinh(x);
            }
            else
                if (radioButton2.Checked)
            {
                return Math.Pow(x, 2);
            }
            else
                return Math.Exp(x);
        }
        double func_1(double x, double y, double z)
        {
            return (Math.Max(func(x) + y + z, x * y * z)) / Math.Min(func(x) + y + z, x * y * z);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Результат";
            textBox4.Text += Environment.NewLine + (("X = ") + (textBox1.Text == "" ? "0" : textBox1.Text));
            textBox4.Text += Environment.NewLine + (("Y = ") + (textBox2.Text == "" ? "0" : textBox2.Text));
            textBox4.Text += Environment.NewLine + (("Z = ") + (textBox3.Text == "" ? "0" : textBox3.Text));

            textBox4.Text += Environment.NewLine + ("Q = " + func_1(
                    textBox1.Text == "" ? 0 : Convert.ToDouble(textBox1.Text.Replace('.', ',')),
                    textBox2.Text == "" ? 0 : Convert.ToDouble(textBox2.Text.Replace('.', ',')),
                    textBox3.Text == "" ? 0 : Convert.ToDouble(textBox3.Text.Replace('.', ','))));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
