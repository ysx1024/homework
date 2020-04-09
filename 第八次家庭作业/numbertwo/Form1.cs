using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using numberone;

namespace numbertwo
{
    public partial class Form1 : Form
    {
        public List<Order> orders = new List<Order>();
        Order order = new Order();
        int inquireType;//查询信息类型
        int orderID;//订单号
        string customer;//顾客
        string commodity;//商品
        public Form1()
        {
            InitializeComponent();

            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 10, "椅子");           //价格 数目 商品名称
            OrderItem d2 = new OrderItem(1, 11, "橘子");
            OrderItem d3 = new OrderItem(2, 5, "香蕉");
            o1.Add(d1);
            o1.Add(d2);
            o1.Add(d3);

            Order o2 = new Order(224, "王");
            OrderItem d4 = new OrderItem(10, 11, "鸡肉");
            OrderItem d5 = new OrderItem(20, 2, "猪肉");
            o2.Add(d4);
            o2.Add(d5);

            Order o3 = new Order(516, "张");
            OrderItem d6 = new OrderItem(50, 1, "手机");
            OrderItem d7 = new OrderItem(15, 10, "瓜子");
            OrderItem d8 = new OrderItem(1, 110, "苹果");
            o3.Add(d6);
            o3.Add(d7);
            o3.Add(d8);

            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);

            bindingSource1.DataSource = orders;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void rB_ID_CheckedChanged(object sender, EventArgs e)
        {
            inquireType = 1;
        }

        private void rB_Cu_CheckedChanged(object sender, EventArgs e)
        {
            inquireType = 2;
        }

        private void rB_Co_CheckedChanged(object sender, EventArgs e)
        {
            inquireType = 3;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (inquireType == 1)
            {
                try
                {
                    orderID = int.Parse(textBox1.Text);
                } catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else if (inquireType==2) 
            {
                try
                {
                    customer = textBox1.Text;
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                try
                {
                    commodity = textBox1.Text;
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                order.OrderID = int.Parse(txt_ID.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            try
            {
                order.Customer = txt_Cu.Text;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            try
            {
                order.PriceSum = int.Parse(txt_Cu.Text);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            orders.Add(order);
            bindingSource1.ResetBindings(false);
        }
        private void btn_Inq_Click(object sender, EventArgs e)
        {
            List<Order> orders1 = new List<Order>();
            if (inquireType == 1)
            {
                foreach (Order o in orders)
                {
                    if (o.OrderID == orderID)
                    {
                        orders1.Add(o);
                        bindingSource1.DataSource = orders1;
                    }
                }
            }
            else if (inquireType==2)
            {
                foreach (Order o in orders)
                {
                    if (o.Customer == customer)
                    {
                        orders1.Add(o);
                        bindingSource1.DataSource = orders1;
                    }
                }
            }
            else
            {
                foreach (Order o in orders)
                {
                    foreach (OrderItem d in o.orderItems)
                    {
                        if (d.Commodity== commodity)
                        {
                            orders1.Add(o);
                            bindingSource1.DataSource = orders1;
                        }
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

    }
}
