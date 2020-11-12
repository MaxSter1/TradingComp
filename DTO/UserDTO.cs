using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Phone { get; set; }
        public long RoleId { get; set; }
        public byte[] Password { get; set; }
        public string Salt { get; set; }
    }
}
