using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Data.Entity.Migrations;
using System.Security.Cryptography;

namespace DAL.Concrete
{
    public class UserDal : IUserDal
    {
        private readonly IMapper _mapper;
        public UserDal(IMapper mapper)
        {
            _mapper = mapper;
        }
        public UserDTO CreateUser(UserDTO user)
        {
            using(var e  = new DbEntities())
            {
                if(e.User.Any(p => p.Login == user.Login))
                {
                    throw new Exception("User exist.");
                }
                User u = _mapper.Map<User>(user);
                e.User.Add(u);
                e.SaveChanges();
                return _mapper.Map<UserDTO>(u);
            }
        }
        public UserDTO CreateUser(UserDTO user,string password)
        {
            using (var e = new DbEntities())
            {
                if (e.User.Any(p => p.Login == user.Login))
                {
                    throw new Exception("User exist.");
                }

                Guid salt = Guid.NewGuid();
                user.Password = hash(password, salt.ToString());
                user.Salt = salt.ToString();

                User u = _mapper.Map<User>(user);
                e.User.Add(u);
                e.SaveChanges();
                return _mapper.Map<UserDTO>(u);
            }
        }

        public void DeleteUserById(int id)
        {
            using (var e = new DbEntities())
            {
                var user = e.User.SingleOrDefault(p => p.Id == id);
                if (user == null) return;
                e.User.Remove(user);
                e.SaveChanges();
            }
        }

        public List<UserDTO> GetAllUsers()
        {
            using (var e = new DbEntities())
            {
                return _mapper.Map<List<UserDTO>>(e.User.ToList());
            }
        }

        public UserDTO GetUserById(int id)
        {
            using (var e = new DbEntities())
            {
                var user = e.User.SingleOrDefault(p => p.Id == id);
                return _mapper.Map<UserDTO>(user);
            }
        }

        public UserDTO GetUserByLogin(string login)
        {
            using (var e = new DbEntities())
            {
                var user = e.User.SingleOrDefault(p => p.Login == login);
                return _mapper.Map<UserDTO>(user);
            }
        }

        public bool Login(string login, string pass)
        {
            var user = this.GetUserByLogin(login);
            return user != null && user.Password.SequenceEqual(hash(pass,user.Salt));
        }
        private byte[] hash(string password, string salt)
        {
            var alg = SHA512.Create();
            return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }

        public UserDTO UpdateUser(UserDTO user)
        {
            using (var e = new DbEntities())
            {
                e.User.AddOrUpdate(_mapper.Map<User>(user));
                e.SaveChanges();
                return _mapper.Map<UserDTO>(e.User.SingleOrDefault(p => p.Login == user.Login));
            }
        }
    }
}
