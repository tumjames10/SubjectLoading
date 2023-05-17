using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LS.Model
{
    public class ViewRoomSubjectSchedule : BaseEntity
    {
        public int RoomSubjectScheduleID { get; set; }

        public Subject Subject { get; set; }

        public Room Room { get; set; }
    }
}
