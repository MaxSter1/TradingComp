using BusinessLogic.Interface;
using DAL.Interface;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class RoleManager:IRoleManager
    {
        private readonly IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<RoleDTO> GetAllRoles()
        {
            return _roleDal.GetAllRoles();
        }
    }
}
