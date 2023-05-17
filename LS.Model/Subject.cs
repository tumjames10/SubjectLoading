using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LS.Model
{
    public class Subject: BaseEntity
    {
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public int? Units { get; set; }

        public int DepartmentID { get; set; }

        public Department? Department { get; set; }

        public int SemesterID { get; set; }
        public Semester? Semester { get; set; }

        public List<RoomSubjectSchedule>? RoomSubjectSchedules { get; set; }


    }
}
