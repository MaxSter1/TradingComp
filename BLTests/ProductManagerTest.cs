using BusinessLogic.Concrete;
using DAL.Interface;
using DTO;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLTests
{
    [TestFixture]
    public class ProductManagerTest
    {
        private Mock<IProductDal> productDal;
        private ProductManager manager;

        [SetUp]
        public void Setup()
        {
            productDal = new Mock<IProductDal>(MockBehavior.Strict);

            manager = new ProductManager(productDal.Object);
        }

        [Test]
        public void GetAllProductsTest()
        {
            var productList = new List<ProductDTO>() { new ProductDTO { Id = 1, CategoryId = 2, EntryPrice = 100, IsLocked = false, Name = "Product", SellingPrice = 148 } };
            productDal.Setup(p => p.GetAllProducts()).Returns(productList);
            var res = manager.GetAllProducts();
            NUnit.Framework.Assert.IsTrue(res.Count > 0);
        }
        [Test]
        public void GetProductByIdTest()
        {
            int id = 1;
            var product = new ProductDTO { Id = id, CategoryId = 2, EntryPrice = 100, IsLocked = false, Name = "Product", SellingPrice = 148 };
            productDal.Setup(p => p.GetProductById(id)).Returns(product);
            var res = manager.GetProductById(id);

            NUnit.Framework.Assert.AreEqual(res.Id,id);
        }
        [Test]
        public void UpdateProductTest()
        {
            var product = new ProductDTO { Id = 1, CategoryId = 2, EntryPrice = 100, IsLocked = false, Name = "Product", SellingPrice = 148 };
            var UpdatedProduct = product;
            productDal.Setup(p => p.UpdateProduct(product)).Returns(UpdatedProduct);
            var res = manager.UpdateProduct(product);
            NUnit.Framework.Assert.AreEqual(res,UpdatedProduct);
        }
    }
}
