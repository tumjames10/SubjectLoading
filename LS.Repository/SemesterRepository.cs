using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class SemesterRepository : BaseRepository<Semester>, ISemesterRepository
    {
        public SemesterRepository(LSContext context) : base(context)
        {
               
        }
    }
}