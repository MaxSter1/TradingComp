using AutoMapper;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ProductDal:IProductDal
    {
        private readonly IMapper _mapper;
        public ProductDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ProductDTO CreateProdust(ProductDTO product)
        {
            using(var e = new DbEntities())
            {
                var prod = _mapper.Map<Products>(product);
                e.Products.Add(prod);
                e.SaveChanges();
                return _mapper.Map<ProductDTO>(prod);
            }
        }

        public void DeleteProductById(int id)
        {
            using (var e = new DbEntities())
            {
                var prod = e.Products.SingleOrDefault(p => p.Id == id);
                if (prod == null) return;
                e.Products.Remove(prod);
                e.SaveChanges();
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            using (var e = new DbEntities())
            {
                return _mapper.Map<List<ProductDTO>>(e.Products.ToList());
            }
        }

        public ProductDTO GetProductById(int id)
        {
            using (var e = new DbEntities())
            {
                var prod = e.Products.SingleOrDefault(p => p.Id == id);
                return _mapper.Map<ProductDTO>(prod);
            }
        }

        public ProductDTO UpdateProduct(ProductDTO product)
        {
            using (var e = new DbEntities())
            {
                e.Products.AddOrUpdate(_mapper.Map<Products>(product));
                e.SaveChanges();
                return _mapper.Map<ProductDTO>(e.Products.SingleOrDefault(p => p.Id == product.Id));
            }
        }
    }
}
