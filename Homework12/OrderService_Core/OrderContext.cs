using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace OrderApp {
    public class OrderContext: DbContext{
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}