﻿using System.Data.Entity;
using MySql.Data.EntityFramework;


namespace OrderApp
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext: DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}