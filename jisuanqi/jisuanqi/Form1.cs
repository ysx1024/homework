using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jisuanqi
{
    public partial class Form1 : Form
    {
        private int s = 1;
        private double a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                s = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                s = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)
            {
                s = 3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton4.Checked)
            {
                s = 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            switch (s)
            {
                case 1:

                    this.label2.Text = $"{a + b}";
                    return;
                case 2:
                    this.label2.Text = $"{a - b}";
                    return;
                case 3:
                    if (a > 0 && b > 0 && a * b < 0)
                    {
                        label2.Text = "数字溢出，请重试";
                        return;
                    }
                    this.label2.Text = $"{a * b}";
                    return;
                case 4:
                    if (b == 0)
                    {
                        label2.Text = "被除数不可为0";
                        return;
                    }
                    this.label2.Text = $"{a / b}";
                    return;
            }
        }
    }
}
