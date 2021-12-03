using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Appointments
    {
        public Guid AppointmentId { get; set; }
        
        public char AppointmentType { get; set; }
        public Guid PatientId { get; set; }
        public Guid PhysicianId { get; set; }
        public Guid NurseId { get; set; }
        public string Diagnosis { get; set; }
        //public Guid DiagnosisId { get; set; }
        //public Guid ProcedureId { get; set; }
        public char Status { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedReason { get; set; }
        public Guid DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedReason { get; set; }
       

    }
}
