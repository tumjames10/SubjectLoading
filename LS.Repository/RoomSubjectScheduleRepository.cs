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
    }
}