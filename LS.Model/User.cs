using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class User : BaseEntity
    {
        public int UserID { get; set; }

        public int? FacultyID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
