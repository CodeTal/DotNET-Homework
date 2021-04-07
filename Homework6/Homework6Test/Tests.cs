using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using NUnit.Framework;
using ordertest;

namespace Homework6Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAddOrder()
        {
            Order order = new Order(17, new Customer(22, "Bob"));
            OrderService orderService = new OrderService();
            List<Order> orders = new List<Order>();
            orderService.AddOrder(order);
            orders.Add(order);
            Assert.AreSame(orders[0], orderService.GetById(17));
        }

        [Test]
        public void TestUpdate()
        {
            Order order = new Order(17, new Customer(22, "Bob"));
            Order neworder = new Order(17, new Customer(25, "Tim"));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.Update(neworder);
            Assert.AreEqual(orderService.QueryAll().Count, 1);
            Assert.AreSame(orderService.GetById(17), neworder);
        }

        [Test]
        public void TestGetById()
        {
            Order order = new Order(17, new Customer(22, "Bob"));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            Assert.AreSame(order, orderService.GetById(17));
        }

        [Test]
        public void TestRemoveOrder()
        {
            Order order = new Order(17, new Customer(22, "Bob"));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order);
            orderService.RemoveOrder(17);
            Assert.AreEqual(orderService.QueryAll().Count, 0);
        }

        [Test]
        public void TestQueryAll()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderService orderService = new OrderService();
            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            CollectionAssert.AreEqual(orders, orderService.QueryAll());
        }

        [Test]
        public void TestQueryByGoodsName()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            OrderDetail detail1 = new OrderDetail(new Goods(1, "Toy", 100), 2);
            OrderDetail detail2 = new OrderDetail(new Goods(2, "Food", 20), 5);
            order1.AddDetails(detail1);
            order1.AddDetails(detail2);

            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderDetail detail3 = new OrderDetail(new Goods(3, "Chip", 50), 1);
            OrderDetail detail4 = new OrderDetail(new Goods(4, "Wood", 300), 3);
            order2.AddDetails(detail3);
            order2.AddDetails(detail4);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Order queryedOrder = orderService.QueryByGoodsName("Wood")[0];
            Assert.AreEqual(queryedOrder.Id, 19);
        }

        [Test]
        public void TestQueryByTotalAmount()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            OrderDetail detail1 = new OrderDetail(new Goods(1, "Toy", 100), 2);
            OrderDetail detail2 = new OrderDetail(new Goods(2, "Food", 20), 5);
            //300
            order1.AddDetails(detail1);
            order1.AddDetails(detail2);

            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderDetail detail3 = new OrderDetail(new Goods(3, "Chip", 50), 1);
            OrderDetail detail4 = new OrderDetail(new Goods(4, "Wood", 300), 3);
            //950
            order2.AddDetails(detail3);
            order2.AddDetails(detail4);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Order queryedOrder = orderService.QueryByTotalAmount(950)[0];
            Assert.AreEqual(queryedOrder.Id, 19);
        }

        [Test]
        public void TestQueryByCustomerName()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            OrderDetail detail1 = new OrderDetail(new Goods(1, "Toy", 100), 2);
            OrderDetail detail2 = new OrderDetail(new Goods(2, "Food", 20), 5);
            order1.AddDetails(detail1);
            order1.AddDetails(detail2);

            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderDetail detail3 = new OrderDetail(new Goods(3, "Chip", 50), 1);
            OrderDetail detail4 = new OrderDetail(new Goods(4, "Wood", 300), 3);
            order2.AddDetails(detail3);
            order2.AddDetails(detail4);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Order queryedOrder = orderService.QueryByCustomerName("Alice")[0];
            Assert.AreEqual(queryedOrder.Id, 19);
        }

        [Test]
        public void TestSort()
        {
            Order order1 = new Order(33, new Customer(22, "Bob"));
            Order order2 = new Order(18, new Customer(22, "Bob"));
            Order order3 = new Order(15, new Customer(22, "Bob"));
            Order order4 = new Order(21, new Customer(22, "Bob"));
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.AddOrder(order4);
            orderService.Sort((o1, o2) => { return o1.Id - o2.Id; });
            int count = 0;
            int[] results = {15, 18, 21, 33};
            orderService.QueryAll().ForEach(order =>
            {
                Assert.AreEqual(order.Id, results[count]);
                count++;
            });
        }

        [Test]
        public void TestExport()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            OrderDetail detail1 = new OrderDetail(new Goods(1, "Toy", 100), 2);
            OrderDetail detail2 = new OrderDetail(new Goods(2, "Food", 20), 5);
            order1.AddDetails(detail1);
            order1.AddDetails(detail2);

            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderDetail detail3 = new OrderDetail(new Goods(3, "Chip", 50), 1);
            OrderDetail detail4 = new OrderDetail(new Goods(4, "Wood", 300), 3);
            order2.AddDetails(detail3);
            order2.AddDetails(detail4);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            if (File.Exists("test.xml"))
            {
                Assert.False(true);
            }
            orderService.Export("test.xml");
            if (!File.Exists("test.xml"))
            {
                Assert.False(true);
            }
        }

        [Test]
        public void TestImport()
        {
            Order order1 = new Order(17, new Customer(22, "Bob"));
            OrderDetail detail1 = new OrderDetail(new Goods(1, "Toy", 100), 2);
            OrderDetail detail2 = new OrderDetail(new Goods(2, "Food", 20), 5);
            order1.AddDetails(detail1);
            order1.AddDetails(detail2);

            Order order2 = new Order(19, new Customer(31, "Alice"));
            OrderDetail detail3 = new OrderDetail(new Goods(3, "Chip", 50), 1);
            OrderDetail detail4 = new OrderDetail(new Goods(4, "Wood", 300), 3);
            order2.AddDetails(detail3);
            order2.AddDetails(detail4);
            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            
            FileStream fs = new FileStream("test.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            List<Order> orders = (List<Order>) xmlSerializer.Deserialize(fs);
            CollectionAssert.AreEqual(orderService.QueryAll(),orders);
        }
    }
}