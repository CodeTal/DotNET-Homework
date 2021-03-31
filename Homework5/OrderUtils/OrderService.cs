using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace OrderUtils
{
    public class OrderService
    {
        public OrderService()
        {
            orders = new List<Order>();
        }

        public void add(Order newOrder)
        {
            foreach (var order in orders)
            {
                if (order.Equals(newOrder))
                {
                    return;
                }
            }
            orders.Add(newOrder);
        }

        public List<Order> queryByID(int id)
        {
            var query = from order in orders
                where order.ID == id
                orderby order.Price
                select order;
            if (query == null || query.Count() == 0) throw new KeyNotFoundException();
            return query.ToList();
        }

        public List<Order> queryByGoodsName(String goodsName)
        {
            var query = from order in orders
                where order.GoodsName == goodsName
                orderby order.Price
                select order;
            if (query == null || query.Count() == 0) throw new KeyNotFoundException();
            return query.ToList();
        }

        public List<Order> queryByCustomerName(String customerName)
        {
            var query = from order in orders
                where order.CustomerName == customerName
                orderby order.Price
                select order;
            if (query == null || query.Count() == 0) throw new KeyNotFoundException();
            return query.ToList();
        }

        public List<Order> queryByPrice(int price)
        {
            var query = from order in orders
                where order.Price == price
                orderby order.Price
                select order;
            if (query == null || query.Count() == 0) throw new KeyNotFoundException();
            return query.ToList();
        }

        public void deleteByID(int id)
        {
            List<Order> query;
            try
            {
                query = queryByID(id);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }
        }

        public void deleteByGoodsName(String goodsName)
        {
            List<Order> query;
            try
            {
                query = queryByGoodsName(goodsName);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }
        }

        public void deleteByCustomerName(String customerName)
        {
            List<Order> query;
            try
            {
                query = queryByCustomerName(customerName);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }
        }

        public void deleteByPrice(int price)
        {
            List<Order> query;
            try
            {
                query = queryByPrice(price);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }
        }

        public void updateByID(int id, Order newOrder)
        {
            List<Order> query;
            try
            {
                query = queryByID(id);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }

            orders.Add(newOrder);
        }

        public void updateByGoodsName(String goodsName, Order newOrder)
        {
            List<Order> query;
            try
            {
                query = queryByGoodsName(goodsName);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }

            orders.Add(newOrder);
        }

        public void updateByCustomerName(String customerName, Order newOrder)
        {
            List<Order> query;
            try
            {
                query = queryByCustomerName(customerName);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }

            orders.Add(newOrder);
        }

        public void updateByPrice(int price, Order newOrder)
        {
            List<Order> query;
            try
            {
                query = queryByPrice(price);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("未找到数据");
                return;
            }

            for (int i = 0; i < query.Count(); i++)
            {
                orders.Remove(query.ToList()[i]);
            }

            orders.Add(newOrder);
        }

        public void sort()
        {
            orders.Sort((p1,p2) => p1.ID - p2.ID);
        }

        private List<Order> orders;
    }
}