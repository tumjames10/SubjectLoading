using LS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IInstructorScheduleRepository : IRepository<InstructorSchedule>
    {
        List<InstructorSchedule> GetInstructorSchedule(int facultyID, int semesterID);
    }
}
