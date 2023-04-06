using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class InstructorScheduleRepository : BaseRepository<InstructorSchedule>, IInstructorScheduleRepository
    {
        public InstructorScheduleRepository(LSContext context) : base(context)
        {
               
        }
    }
}