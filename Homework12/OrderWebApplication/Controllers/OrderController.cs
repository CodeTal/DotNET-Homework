using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApp;

namespace OrderWebApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController:ControllerBase
    {
        private readonly OrderContext orderDB;

        public OrderController(OrderContext context)
        {
            this.orderDB = context;
        }

        [HttpGet]
        public ActionResult<List<Order>> getOrderItems(string name)
        {
            IQueryable<Order> query = orderDB.Orders.Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem).Include("Customer");
            if (name != null)
            {
                query = query.Where(o => o.Customer.Name.Contains(name));
            }

            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> getOrderItem(string id)
        {
            var order = orderDB.Orders.Include(o => o.Details)
                .ThenInclude(d => d.GoodsItem).Include("Customer").FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        [HttpPost]
        public ActionResult<Order> postOrderItem(Order order)
        {
            try
            {
                orderDB.Orders.Add(order);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return order;
        }

        [HttpPut("{id}")]
        public ActionResult<Order> putOrderItem(string id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }

            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Order> deleteOrderItem(string id)
        {
            try
            {
                var order = orderDB.Orders.Include(o => o.Details)
                    .ThenInclude(d => d.GoodsItem).Include("Customer").FirstOrDefault(o => o.OrderId == id);
                if (order != null)
                {
                    orderDB.Remove(order);
                    orderDB.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return NoContent();
        }
    }
}