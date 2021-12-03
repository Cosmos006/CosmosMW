using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Notes
    {
        public Guid NotesId { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecieverId { get; set; }
        public string SenderMessage { get; set; }
        public string ResponseMessage { get; set; }
        public DateTime SentDateTime { get; set; }
        public DateTime RecievedDateTime { get; set; }
    }
}
