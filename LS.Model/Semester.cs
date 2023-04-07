using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public  class Semester : BaseEntity
    {
        public int SemesterID { get; set; }

        public string SemesterName { get; set; }

        public string Year { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
