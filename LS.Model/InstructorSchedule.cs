using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class InstructorSchedule : BaseEntity
    {
        public int InstructorScheduleID { get; set; }

        public int FacultyID { get; set; }


        public int AdminID { get; set; }


        public int RoomSubjectScheduleID { get; set; }

        public RoomSubjectSchedule? RoomSubjectSchedule { get; set; }

    }
}
