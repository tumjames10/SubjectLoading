 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class Request: BaseEntity
    {
        public int RequestID { get; set; }

        public int RequesterID { get; set; }

        public int RequestedToID { get; set; }

        public DateTime? ApprovedOn { get; set; }

        public int SemesterID { get; set;  }
        
        public bool IsApproved { get; set; }

        public string Comment { get; set; }
        
        public string IsRead { get; set; }
    }
}
