using LS.Model;
using LS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository
{
    public class AllRepository : IAllRepository
    {
        public IDepartmentRepository DepartmentRepository { get; set; }
        public IFacultyRepository FacultyRepository { get; set; }
        public IInstructorScheduleRepository InstructorScheduleRepository { get; set; }
        public ILocationRepository LocationRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public IRoomSubjectScheduleRepository RoomSubjectScheduleRepository { get; set; }
        public IScheduleRepository ScheduleRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public ISubjectScheduleRepository SubjectScheduleRepository { get; set; }

        public AllRepository(LSContext context)
        {
            DepartmentRepository = new DepartmentRepository(context);
            FacultyRepository = new FacultyRepository(context);
            InstructorScheduleRepository = new InstructorScheduleRepository(context);
            LocationRepository = new LocationRepository(context);
            RoomRepository = new RoomRepository(context);
            RoomSubjectScheduleRepository = new RoomSubjectScheduleRepository(context);
            ScheduleRepository = new ScheduleRepository(context);
            SubjectRepository = new SubjectRepository(context);
            SubjectScheduleRepository = new SubjectScheduleRepository(context);
        }
    }
}
