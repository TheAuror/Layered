using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using LayeredSolution.DataLayer;
using LayeredSolution.DataLayer.Schema;

namespace LayeredSolution.BusinessLayer.ProductModels
{
    public class ProductService : BaseService, IProductService
    {
        private BindingList<ProductModel> _productModels; 
        public ProductService(ISampleContext context) : base(context)
        {
        }
        
        public List<ProductModel> GetAllProduct(string search)
        {
            IQueryable<Product> query = Context.Products;
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(e => e.Name.Contains(search)
                                 || e.ProductNo.Contains(search));
            }
            return query.Select(e => new ProductModel
            {
                Id = e.Id,
                Name = e.Name,
                ProductNo = e.ProductNo,
                Price = e.Price
            }).ToList();
        }

        public BindingList<ProductModel> GetProductEditModel()
        {
            return _productModels ?? (_productModels = new BindingList<ProductModel>(GetAllProduct(null)));
        }

        public void SaveProduct()
        {
            if(_productModels == null) return;
            var productRows = Context.Products.ToList();
            foreach (var productModel in _productModels)
            {
                Product productRow;
                if (productModel.Id > 0)
                {
                    productRow = productRows.FirstOrDefault(e => e.Id == productModel.Id);
                }
                else
                {
                    productRow = new Product();
                    productRows.Add(productRow);
                    Context.Products.Add(productRow);
                }
                if (productRow == null) continue;
                productRow.Name = productModel.Name;
                productRow.ProductNo = productModel.ProductNo;
                productRow.Price = productModel.Price;
            }
            Context.SaveChanges();
            _productModels.Clear();
            foreach (var productModel in GetAllProduct(null))
            {
                _productModels.Add(productModel);
            }
        }

    }
}
