using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public  class Location  : BaseEntity
    {

        public int LocationID { get; set; }

        public string BuildingName { get; set; }

        public string Address { get; set; }
    }
}
