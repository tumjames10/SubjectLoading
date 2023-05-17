using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LS.Model
{
    public class Faculty : BaseEntity
    {

        public int FacultyId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Gender { get; set; }

        public DateTime DOB { get; set; } = DateTime.Now;

        public string Address { get; set; }

        public string Title { get; set; }

        public string Photo { get; set;  }

        public int DepartmentID { get; set; }

        public Department? Department { get; set; }

        public FacultyType FacultyType { get; set; }
    }
}
