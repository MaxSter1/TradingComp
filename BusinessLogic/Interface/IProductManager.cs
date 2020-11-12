using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IProductManager
    {
        List<ProductDTO> GetAllProducts();
        ProductDTO GetProductById(int id);
        ProductDTO UpdateProduct(ProductDTO product);
    }
}
