using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class RoomSubjectSchedule : BaseEntity
    {

        public int RoomSubjectScheduleID { get; set; }

        public string Day { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public int RoomID { get; set; }

        public Room? Room { get; set; }


        public int SubjectID { get; set; }

        public Subject? Subject { get; set;  }

        public List<InstructorSchedule>? InstructorSchedules { get; set; }
    }
}
