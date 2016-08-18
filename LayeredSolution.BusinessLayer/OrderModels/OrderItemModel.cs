﻿using LayeredSolution.DataLayer;

namespace LayeredSolution.BusinessLayer
{
    public class OrderItemModel
    {
        public virtual int Id { get; set; }
        public virtual int? OrderId { get; set; }
        public virtual OrderModel Order { get; set; }
        public virtual int? ProductId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual int Price { get; set; }
        public string ProductName { get; set; }
        public string ProductNo { get; set; }
        public int SumPrice
        {
            get
            {
                return Quantity*Price;
            }
        }
    }
}