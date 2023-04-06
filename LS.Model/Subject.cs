﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class Subject : BaseEntity
    {
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public int? Units { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        public List<SubjectSchedule> SubjectSchedules { get; set; }


    }
}