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
        public IRoomRepository RoomRepository { get; set; }
        public IRoomSubjectScheduleRepository RoomSubjectScheduleRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public ISemesterRepository SemesterRepository { get; set; }
        public IRequestRepository RequestRepository { get; set; }
        public IUserRepository UserRepository { get; set; }
        public AllRepository(LSContext context)
        {
            DepartmentRepository = new DepartmentRepository(context);
            FacultyRepository = new FacultyRepository(context);
            InstructorScheduleRepository = new InstructorScheduleRepository(context);
            RoomRepository = new RoomRepository(context);
            RoomSubjectScheduleRepository = new RoomSubjectScheduleRepository(context);
            SubjectRepository = new SubjectRepository(context);
            SemesterRepository = new SemesterRepository(context);
            RequestRepository = new RequestRepository(context);
            UserRepository = new UserRepository(context);
        }
    }
}
