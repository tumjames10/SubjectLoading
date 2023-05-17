using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace LS.Repository
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(LSContext context) : base(context)
        {
               
        }

        public List<Subject> GetAllSubjects(int semesterID)
        {
            return this.DbContext.Subject.Where(j => j.SemesterID == semesterID).Include(j => j.Semester).ToList();
        }
    }
}