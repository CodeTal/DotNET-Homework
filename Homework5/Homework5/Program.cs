using System;
using OrderUtils;

namespace Homework5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(1, "TV", 2000, new DateTime(2021, 3, 7), "Bob", 107, "Jack", 233);
            Order order2 = new Order(2, "Phone", 3000, new DateTime(2021, 3, 8), "Dale", 357, "Mark", 534);
            Order order3 = new Order(3, "Car", 4000, new DateTime(2021, 3, 9), "Frank", 209, "Tim", 177);
            orderService.add(order1);
            orderService.add(order2);
            orderService.add(order3);
            orderService.deleteByID(1);
            orderService.deleteByPrice(6004);//找不到
            orderService.updateByCustomerName("Tim",new Order(4,"CS",5000,new DateTime(2017,3,4), "A",444,"B",666));
            Console.WriteLine(orderService.queryByPrice(3000)[0].CustomerName);
            Console.WriteLine(orderService.queryByPrice(5000)[0].ID);
        }
    }
}