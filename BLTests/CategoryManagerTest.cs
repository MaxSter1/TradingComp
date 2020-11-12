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
    public class CategoryManagerTest
    {
        private Mock<ICategoryDal> categoryDal;
        private CategoryManager manager;

        [SetUp]
        public void Setup()
        {
            categoryDal = new Mock<ICategoryDal>(MockBehavior.Strict);

            manager = new CategoryManager(categoryDal.Object);
        }

        [Test]
        public void GetAllCategoriesTest()
        {
            var categoryList = new List<CategoryDTO>() { new CategoryDTO { Id = 1, Name = "category1" }, new CategoryDTO { Id = 2, Name = "category2" } };
            categoryDal.Setup(p => p.GetAllCategories()).Returns(categoryList);
            var res = manager.GetAllCategories();
            NUnit.Framework.Assert.IsTrue(res.Count>0);
        }

    }
}
