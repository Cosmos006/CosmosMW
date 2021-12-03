using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class PatientRelativeDetails
    {
        public Guid PatientRelativeDetailsId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Relation { get; set; }
        public string Email { get; set; }
        public double Contact { get; set; }
    }
}
