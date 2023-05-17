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

        public List<InstructorSchedule> GetInstructorSchedule(int facultyID, int semesterID)
        {
            var a = this.DbContext.InstructorSchedule.Where(j => j.FacultyID == facultyID).ToList();

            return this.DbContext.InstructorSchedule.Where(j => j.FacultyID == facultyID)
                .Include(j => j.RoomSubjectSchedule.Subject)
                .Include(j => j.RoomSubjectSchedule.Room)
                .Where(j => j.RoomSubjectSchedule.Subject.SemesterID == semesterID).ToList();
        }
    }
}