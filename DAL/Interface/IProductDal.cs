using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IProductDal
    {
        ProductDTO CreateProdust(ProductDTO product);
        List<ProductDTO> GetAllProducts();
        void DeleteProductById(int id);

        ProductDTO UpdateProduct(ProductDTO product);
        ProductDTO GetProductById(int id);


    }
}
