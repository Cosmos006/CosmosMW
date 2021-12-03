using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Master
{
    public class Diagnosis
    {
        public Guid DiagnosisId { get; set; }
        public string DiagnosisCode { get; set; }
        public string Description { get; set; }
        public Boolean IsDepricated { get; set; }
    }
}
