using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberone
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public int PriceSum { get; set; }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order()
        {

        }
        public Order(int OrderID, string Customer)
        {
            this.OrderID = OrderID;
            this.Customer = Customer;
        }
        public void Add(OrderItem orderItem)
        {
            bool isRepeat = false;
            foreach (OrderItem o in orderItems)
            {
                if (orderItem.Equals(o))
                {
                    isRepeat = true;
                    break;
                }
            }
            if (!isRepeat)
            {
                orderItems.Add(orderItem);
                PriceSum += orderItem.Number * orderItem.Price;
            }
        }
        public void getPriceSum()
        {
            int total = 0;
            foreach (OrderItem o in orderItems)
            {
                total += o.Number * o.Price;
            }
            this.PriceSum = total;
        }

       public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID &&
                   Customer == order.Customer;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string s = "";
            foreach (OrderItem o in orderItems)
            {
                s += o.ToString();
            }
            return "订单号:" + OrderID + "\n客户名:" + Customer + "\n总价:" + PriceSum + "\n订单明细:" + s + "\n";
        }
    }
    public class OrderItem
    {
        public int Price { get; set; }
        public int Number { get; set; }
        public string Commodity { get; set; }
        public OrderItem()
        {

        }
        public OrderItem(int Price, int Number, string Commodity)
        {
            this.Price = Price;
            this.Number = Number;
            this.Commodity = Commodity;
        }
        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   Price == item.Price &&
                   Number == item.Number &&
                   Commodity == item.Commodity;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "\n 商品名：" + Commodity + " 数目：" + Price + " 单价：" + Number;
        }
    }
    public class OrderService
    {
        List<Order> orders = new List<Order>();

        //添加订单
        public void add(Order o)
        {
            bool isRepeat = false;
            foreach (Order order in orders)
            {
                if (order.Equals(o))
                {
                    isRepeat = true;
                    break;
                }
            }
            if (!isRepeat)
            {
                orders.Add(o);
            }
            else
            {
                Console.WriteLine("重复了");
            }
            //自动排序
            //sort();
        }

        //删除订单
        public void delete(Order o)
        {
            orders.Remove(o);
        }

        //排序
        public void sort()
        {
            orders.Sort((Order o1, Order o2) => o1.OrderID.CompareTo(o2.OrderID));
        }

        //显示全部订单
        public void show()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        //订单号查找
        public void seekOrderID(int a)
        {
            var query = from o in orders
                        where o.OrderID == a
                        orderby o.PriceSum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        //客户名查询
        public void seekCustomer(string a)
        {
            var query = from o in orders
                        where o.Customer == a
                        orderby o.PriceSum
                        select o;
            List<Order> list = query.ToList();
            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        //商品名查询
        public void seekCommodity(string a)
        {
            foreach (Order o in orders)
            {
                foreach (OrderItem d in o.orderItems)
                {
                    if (d.Commodity == a)
                    {
                        Console.WriteLine(o.ToString());
                        break;
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 10, "椅子");           //价格 数目 商品名称
            OrderItem d2 = new OrderItem(1, 11, "苹果");
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

            OrderService orderService = new OrderService();
            orderService.add(o1);
            orderService.add(o2);
            orderService.add(o3);

            //orderService.show();//显示所有订单

            orderService.seekCustomer("闫");
            orderService.seekOrderID(224);
            orderService.seekCommodity("苹果");

            Console.ReadLine();
        }
    }
}
