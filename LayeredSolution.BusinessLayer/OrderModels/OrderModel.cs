using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using LayeredSolution.BusinessLayer.OrderModels;

namespace LayeredSolution.BusinessLayer
{
    public class OrderModel
    {
        public virtual int Id { get; set; }
        public virtual string BuyerName { get; set; }
        public virtual string BuyerEmail { get; set; }
        public virtual string BuyerAddress { get; set; }
        public virtual BindingList<OrderItemModel> OrderItems { get; set; } = new BindingList<OrderItemModel>();
        public int SumPrice
        {
            get
            {
                return OrderItems.Sum(e => e.Price * e.Quantity);
            }
        }
        public int SumQuantity
        {
            get
            {
                return OrderItems.Sum(e => e.Quantity);
            }
        }
    }
}