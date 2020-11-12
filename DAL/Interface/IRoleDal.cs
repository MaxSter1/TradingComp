using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRoleDal
    {
        RoleDTO CreateRole(RoleDTO role);
        List<RoleDTO> GetAllRoles();
        RoleDTO GetRoleById(int id);
        void DeleteRoleById(int id);
    }
}
