using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Master
{
    public class Allergy
    {
        public Guid AllergyId { get; set; }
        public string AllergyCode { get; set; }
        public string AllergyType { get; set; }
        public string AllergyName { get; set; }
        public string ClinicalInformation { get; set; }

    }
}
