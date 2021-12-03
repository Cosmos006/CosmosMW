using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Master
{
    public class Procedure
    {
        public Guid ProcedureId { get; set; }
        public string ProcedureCode { get; set; }
        public string Description { get; set; }
        public Boolean IsDepricated { get; set; }

    }
}
