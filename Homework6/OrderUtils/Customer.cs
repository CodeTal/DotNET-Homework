using System;

namespace OrderUtils
{
    public class Customer
    {
        public Customer(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name => name;

        public int Id => id;

        private String name;
        private int id;
    }
}