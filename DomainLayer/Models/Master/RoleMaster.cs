using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Master
{
    public class RoleMaster
    {
        public Guid RoleId { get; set; }
        public string Role { get; set; }

        public ICollection<RoleMaster> lstRoleMaster { get; set; }
    }
}
