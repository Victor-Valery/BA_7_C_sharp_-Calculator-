using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BA_C_SHARP_7__Calculator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Number_1, Number_2, Result;

            Number_1 = double.Parse(textBox1.Text);
            Number_2 = double.Parse(textBox2.Text);

            Result = Number_1 + Number_2;
            textBox3.Text = Result.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double Number_1, Number_2, Result;

            Number_1 = double.Parse(textBox1.Text);
            Number_2 = double.Parse(textBox2.Text);

            Result = Number_1 - Number_2;
            textBox3.Text = Result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Number_1, Number_2, Result;

            Number_1 = double.Parse(textBox1.Text);
            Number_2 = double.Parse(textBox2.Text);

            Result = Number_1 * Number_2;
            textBox3.Text = Result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Number_1, Number_2, Result;

            Number_1 = double.Parse(textBox1.Text);
            Number_2 = double.Parse(textBox2.Text);

            Result = Number_1 / Number_2;
            textBox3.Text = Result.ToString();
        }
    }
}
