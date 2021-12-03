using DomainLayer.Models.Master;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UserDetails
    {
        public Guid UserDetailsId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public string RoleId { get; set; }
        public Boolean Status { get; set; }   
       //[Column("IsFirstLogIn")]
       // public BitArray IsFirstLogInFeild { get; set; }
        //[NotMapped]
        public Boolean IsFirstLogIn { get; set; }
        public int NoOfAttempts { get; set; }

        [ForeignKey("RoleMaster")]
        public Guid RoleId { get; set; }
        public RoleMaster RoleMaster { get; set; }

    }
}
