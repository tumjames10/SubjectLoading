using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IAllRepository
    {
        IDepartmentRepository DepartmentRepository { get; set; }

        IFacultyRepository FacultyRepository { get; set; }

        IInstructorScheduleRepository InstructorScheduleRepository { get; set; }

        ILocationRepository LocationRepository { get; set; }

        IRoomRepository RoomRepository { get; set; }

        IRoomSubjectScheduleRepository RoomSubjectScheduleRepository { get; set; }

        IScheduleRepository ScheduleRepository { get; set; }

        ISubjectRepository SubjectRepository { get; set; }

        ISubjectScheduleRepository SubjectScheduleRepository { get; set; }

        ISemesterRepository SemesterRepository { get; set; }
    }
}
