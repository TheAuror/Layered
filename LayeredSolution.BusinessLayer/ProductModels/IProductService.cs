using System.Collections.Generic;
using System.ComponentModel;

namespace   LayeredSolution.BusinessLayer.ProductModels
{
    public interface IProductService
    {
        List<ProductModel> GetAllProduct(string search);
        BindingList<ProductModel> GetProductEditModel();
        void SaveProduct();
    }
}
