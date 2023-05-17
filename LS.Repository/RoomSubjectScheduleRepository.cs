using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class RoomSubjectScheduleRepository : BaseRepository<RoomSubjectSchedule>, IRoomSubjectScheduleRepository
    {
        public RoomSubjectScheduleRepository(LSContext context) : base(context)
        {
               
        }

        public List<ViewRoomSubjectSchedule> GetRoomSubjectList(int semesterID, string day)
        {
            

            return new List<ViewRoomSubjectSchedule>();
        }

        public RoomSubjectSchedule GetRoomSubjectSchedule(int Id)
        {

            var roomSubject = this.DbContext.RoomSubjectSchedule.FirstOrDefault(j => j.RoomSubjectScheduleID == Id);

            roomSubject.Room = this.DbContext.Room.FirstOrDefault(j => j.RoomID == roomSubject.RoomID);


            return roomSubject;
        }
    }
}