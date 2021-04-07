using System;

namespace OrderUtils
{
    public class Order
    {
        public Order(int id, String goodsName, int goodsPrice, DateTime time, String fromName, int fromid, String toName, int toid)
        {
            this.id = id;
            this.detail = new OrderDetails(goodsName, goodsPrice);
            this.time = time;
            this.from = new Customer(fromName, fromid);
            this.to = new Customer(toName, toid);
        }

        public override bool Equals(object obj)
        {
            Order comparedOrder = obj as Order;
            return comparedOrder == null || comparedOrder.ID == id;
        }

        public override string ToString()
        {
            return $"ID:{id}; GoodsName:{GoodsName}; Price:{Price}; CustomerName:{CustomerName}";
        }

        public int ID => id;
        public String GoodsName => detail.GoodsName;
        public int Price => detail.GoodsPrice;
        public String CustomerName => to.Name;
        private int id;
        private OrderDetails detail;
        private DateTime time;
        private Customer from;
        private Customer to;
    }
}