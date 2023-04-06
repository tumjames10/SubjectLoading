using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public  class Schedule : BaseEntity
    {
        public int ScheduleID { get; set; }

        public string Day { get; set; }

        public DateTime From { get; set; }
          
        public DateTime To { get; set; }

    }
}
