using LS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IRoomSubjectScheduleRepository : IRepository<RoomSubjectSchedule>
    {

        List<ViewRoomSubjectSchedule> GetRoomSubjectList(int semesterID, string day);

        RoomSubjectSchedule GetRoomSubjectSchedule(int Id);
    }
}
