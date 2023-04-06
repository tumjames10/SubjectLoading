using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public  class SubjectSchedule : BaseEntity
    {

        public int SubjectScheduleID  { get; set; }


        public int SubjectID { get; set; }

        public Subject Subject { get; set; }


        public int ScheduleID { get; set; }

        public Schedule Schedule { get; set; }


        public List<RoomSubjectSchedule> RoomSubjectSchedules { get; set; }

        public List<InstructorSchedule> InstructorSchedules { get; set; }
    }
}
