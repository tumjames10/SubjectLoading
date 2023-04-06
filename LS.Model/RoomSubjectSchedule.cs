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

        public int RoomID { get; set; }

        public Room Room { get; set; }


        public int SubjectScheduleID { get; set; }

        public SubjectSchedule SubjectSchedule { get; set; }

    }
}
