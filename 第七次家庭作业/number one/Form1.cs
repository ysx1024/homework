using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_one
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        int n, x, y;
        int color;
        double leng;
        double th1, th2;
        double per1;
        double per2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.panel1.CreateGraphics();
            drawCayleyTree(n, 200,400, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n-1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n-1, x1, y1, per2 * leng, th-th2);

        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            if (color == 1)
            {
                graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
            }
            else if(color==2)
            {
                graphics.DrawLine(Pens.Orange, (int)x0, (int)y0, (int)x1, (int)y1);
            }
        }
        private void txtN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(txtN.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtLeng_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leng = Convert.ToInt32(txtLeng.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void txtTh1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(txtTh1.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            th1 = x * Math.PI / 180;
        }

        private void txtTh2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                y = Convert.ToInt32(txtTh2.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            th2 = y * Math.PI / 180;
        }

        private void txtPer1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per1 = Convert.ToDouble(txtPer1.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPer2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per2 = Convert.ToDouble(txtPer2.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void rdoColor1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                color = 1;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void rdoColor2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                color = 2;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
