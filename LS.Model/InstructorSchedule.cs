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

        public Faculty Instructor { get; set; }

        public int SubjectScheduleID { get; set; }

        public SubjectSchedule SubjectSchedule { get; set; }


        /// <summary>
        /// Admin who scheduled to instructor
        /// </summary>
        public int AdminFacultyID { get; set; }

        public Faculty AdminFaculty { get; set; }
    }
}
