using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public  class Department : BaseEntity
    {
        public int DepartmentID { get; set; }

        public string Name { get; set; }

        public string Allias { get; set; }

        public List<Subject> Subjects { get; set; }

        public List<Faculty> Faculties { get; set; }
    }
}
