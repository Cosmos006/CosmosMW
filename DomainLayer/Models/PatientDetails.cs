using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class PatientDetails
    {
        public Guid PatientDetailsId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Contact { get; set; }

        [ForeignKey("PatientDemographicDetails")]
        public Guid PatientDemographicId { get; set; }
        public PatientDemographicDetails PatientDemographicDetails { get; set; }
       
        [ForeignKey("UserDetails")]
        public Guid UserId { get; set; }
        public UserDetails UserDetails { get; set; }
        public Boolean IsActive { get; set; }

    }
}
