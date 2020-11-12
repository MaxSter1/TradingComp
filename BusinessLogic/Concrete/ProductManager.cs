using BusinessLogic.Interface;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class ProductManager:IProductManager
    {
        private readonly IProductDal _productDal;
        public  ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<ProductDTO> GetAllProducts()
        {
            return _productDal.GetAllProducts();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDal.GetProductById(id);
        }

        public ProductDTO UpdateProduct(ProductDTO product)
        {
            return _productDal.UpdateProduct(product);
        }
    }
}
