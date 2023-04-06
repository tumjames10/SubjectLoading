using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class SubjectScheduleRepository : BaseRepository<SubjectSchedule>, ISubjectScheduleRepository
    {
        public SubjectScheduleRepository(LSContext context) : base(context)
        {
               
        }
    }
}