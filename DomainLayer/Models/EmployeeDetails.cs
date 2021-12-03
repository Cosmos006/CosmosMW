using DomainLayer.Models.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class EmployeeDetails
    {
        public Guid EmployeeId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Contact { get; set; }
        public string Specialization { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }

        [ForeignKey("RoleMaster")]
        public Guid RoleId { get; set; }
        public RoleMaster RoleMaster { get; set; }

        [ForeignKey("UserDetails")]
        public Guid UserId { get; set; }
        public UserDetails UserDetails { get; set; }

        //public Guid UserId { get; set; }
        public Boolean IsActive { get; set; }

    }
}
