using System;

namespace OrderUtils
{
    public class OrderDetails
    {
        public OrderDetails(String goodsName, int goodsPrice)
        {
            this.goodsName = goodsName;
            this.goodsPrice = goodsPrice;
        }

        public override string ToString()
        {
            return $"GoodsName:{GoodsName}; GoodsPrice:{goodsPrice}";
        }

        public string GoodsName => goodsName;

        public int GoodsPrice => goodsPrice;

        private String goodsName;
        private int goodsPrice;
    }
}