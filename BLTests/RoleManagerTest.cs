using BusinessLogic.Concrete;
using DAL;
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
    public class RoleManagerTest
    {
        private Mock<IRoleDal> roleDal;
        private RoleManager manager;

        [SetUp]
        public void Setup()
        {
            roleDal = new Mock<IRoleDal>(MockBehavior.Strict);

            manager = new RoleManager(roleDal.Object);
        }

        [Test]
        public void GetAllRolesTest()
        {
            var roleList = new List<RoleDTO>() { new RoleDTO {Id = 1,Description = "description",Name = "name" } };
            roleDal.Setup(p => p.GetAllRoles()).Returns(roleList);
            var res = manager.GetAllRoles();
            NUnit.Framework.Assert.IsTrue(res.Count >0);
        }
    }
}
