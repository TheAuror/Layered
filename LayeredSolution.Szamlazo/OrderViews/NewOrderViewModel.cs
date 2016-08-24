using LayeredSolution.BusinessLayer;
using LayeredSolution.BusinessLayer.Common;
using LayeredSolution.BusinessLayer.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredSolution.BusinessLayer.OrderModels;
using LayeredSolution.BusinessLayer.ProductModels;

namespace LayeredSolution.Szamlazo.OrderViews
{
    public class NewOrderViewModel : BaseModel
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public NewOrderViewModel(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
            Order = new OrderModel();
        }

        public OrderModel Order { get; set; }

        public void CreateOrder()
        {
            _orderService.CreateOrder(Order);
        }

        public ProductModel GetProduct(string productNo)
        {
            return _productService.GetAllProduct(null).Find(e => e.ProductNo == productNo);
        }
    }
}
