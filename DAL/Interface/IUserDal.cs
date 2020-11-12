using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserDal
    {
        UserDTO CreateUser(UserDTO user);
        UserDTO CreateUser(UserDTO user, string password);
        UserDTO GetUserById(int id);
        UserDTO GetUserByLogin(string login);
        bool Login(string login, string pass);
        List<UserDTO> GetAllUsers();
        void DeleteUserById(int id);
        UserDTO UpdateUser(UserDTO user);

    }
}
