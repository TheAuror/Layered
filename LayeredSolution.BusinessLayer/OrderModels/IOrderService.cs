using System.Collections.Generic;

namespace LayeredSolution.BusinessLayer.OrderModels
{
    public interface IOrderService
    {
        List<OrderModel> GetOrders();
        void CreateOrder(OrderModel orderModel);
    }
}
