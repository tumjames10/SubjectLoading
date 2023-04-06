using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Model
{
    public class Room : BaseEntity
    {
        public int RoomID { get; set; }

        public string RoomNumber { get; set; }

        public int? FloorNumber { get; set; }

        public int LocationID { get; set; }

        public Location Location { get; set; }

        public bool IsAvailable { get; set; }

        public List<RoomSubjectSchedule> RoomSubjectSchedules { get; set; }
    }
}
