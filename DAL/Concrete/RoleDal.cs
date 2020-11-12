using AutoMapper;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class RoleDal : IRoleDal
    {
        private readonly IMapper _mapper;
        public RoleDal(IMapper mapper)
        {
            _mapper = mapper;
        }
        public RoleDTO CreateRole(RoleDTO role)
        {
            using(var e = new DbEntities())
            {
                if(e.Role.Any( p => p.Name == role.Name))
                {
                    throw new Exception("Role with this name exist.");
                }

                Role _role = _mapper.Map<Role>(role);
                e.Role.Add(_role);
                e.SaveChanges();
                return _mapper.Map<RoleDTO>(_role);
            }
        }

        public void DeleteRoleById(int id)
        {
            using (var e = new DbEntities())
            {
                var _role = e.Role.SingleOrDefault(p => p.Id == id);
                if (_role == null) return;
                e.Role.Remove(_role);
                e.SaveChanges();
            }
        }

        public List<RoleDTO> GetAllRoles()
        {
            using (var e = new DbEntities())
            {

                return _mapper.Map<List<RoleDTO>>(e.Role.ToList());
            }
        }

        public RoleDTO GetRoleById(int id)
        {
            using (var e = new DbEntities())
            {
                var _role = e.Role.SingleOrDefault(p => p.Id == id);
                return _mapper.Map<RoleDTO>(_role);
            }
        }
    }
}
