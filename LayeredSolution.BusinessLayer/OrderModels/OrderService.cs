using System.Collections.Generic;
using System.Linq;
using LayeredSolution.DataLayer;
using LayeredSolution.DataLayer.Schema;
using System.ComponentModel;
using System;

namespace LayeredSolution.BusinessLayer
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(ISampleContext context) : base(context)
        {
            
        }
        public List<OrderModel> GetOrders()
        {
            var ordersForUser = Context.Orders
                .Select(e => new OrderModel
                {
                    Id = e.Id,
                    BuyerAddress = e.BuyerAddress,
                    BuyerEmail = e.BuyerEmail,
                    BuyerName = e.BuyerName
                }).ToList();
            foreach(var model in ordersForUser)
            {
                model.OrderItems = new BindingList<OrderItemModel> (Context.OrderItems.Where(e => e.OrderId == model.Id).Select(item => new OrderItemModel
                {
                    Id = item.Id,
                    Price = item.Price,
                    OrderId = item.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    ProductName = item.Product.Name,
                    ProductNo = item.Product.ProductNo
                }).ToList());
            }
            return ordersForUser;
        }

        public void CreateOrder(OrderModel orderModel)
        {
            var order = new Order
            {
                BuyerAddress = orderModel.BuyerAddress,
                BuyerEmail = orderModel.BuyerEmail,
                BuyerName = orderModel.BuyerName,
                OrderItems = orderModel.OrderItems.Select(item => new OrderItem
                {
                    Price = item.Price,
                    OrderId = item.OrderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                }).ToList()
            };
            Context.Orders.Add(order);
            Context.SaveChanges();
        }
    }
}