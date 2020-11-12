using BusinessLogic.Concrete;
using DAL.Concrete;
using DAL.Interface;
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
    public class AuthManagerTest
    {
        private Mock<IUserDal> userDal;
        private AuthManager manager;

        [SetUp]
        public void Setup()
        {
            userDal = new Mock<IUserDal>(MockBehavior.Strict);

            manager = new AuthManager(userDal.Object);
        }

        [Test]
        public void LoginTest()
        {
            string login = "login";
            string pass = "password";
            userDal.Setup(p => p.Login(login, pass)).Returns(true);
            var res = manager.Login(login, pass);
            NUnit.Framework.Assert.IsTrue(res);
        }

    }
}
