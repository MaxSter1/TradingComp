using BusinessLogic.Interface;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IUserDal _userDal;
        public AuthManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public bool Login(string login, string pass)
        {
            return _userDal.Login(login, pass);
        }
    }
}
