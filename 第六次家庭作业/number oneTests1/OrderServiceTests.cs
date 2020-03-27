using Microsoft.VisualStudio.TestTools.UnitTesting;
using number_one;
using System;
using System.Collections.Generic;
using System.Text;

namespace number_one.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()
        {
            OrderService orderService = new OrderService();

            orderService.ToString();

            Console.WriteLine();

            Assert.Fail();
        }

        [TestMethod()]
        public void addTest()
        {
            OrderService orderService = new OrderService();
            Order o3 = new Order(516, "张");
            OrderItem d6 = new OrderItem(50, 1, "手机");
            o3.Add(d6);
            orderService.add(o3);

            orderService.seekOrderID(516);
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteTest()
        {
            OrderService orderService = new OrderService();
            Order o3 = new Order(516, "张");
            OrderItem d6 = new OrderItem(50, 1, "手机");
            o3.Add(d6);
            orderService.delete(o3);

            Assert.Fail();
        }

        [TestMethod()]
        public void sortTest()
        {
            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 11, "椅子");           //价格 数目 商品名称
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

            orderService.sort();
            Assert.Fail();
        }

        [TestMethod()]
        public void seekOrderIDTest()
        {
            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 11, "椅子");           //价格 数目 商品名称
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
            orderService.seekOrderID(516);
            Assert.Fail();
        }

        [TestMethod()]
        public void seekCustomerTest()
        {
            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 11, "椅子");           //价格 数目 商品名称
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

            orderService.seekCustomer("张");
            Assert.Fail();
        }

        [TestMethod()]
        public void seekCommodityTest()
        {
            Order o1 = new Order(1024, "闫");
            OrderItem d1 = new OrderItem(9, 11, "椅子");           //价格 数目 商品名称
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

            orderService.seekCommodity("苹果");
            Assert.Fail();
        }
    }
}