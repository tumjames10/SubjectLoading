using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomSubjectScheduleController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public RoomSubjectScheduleController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<RoomSubjectScheduleController>
        [HttpGet]
        public IEnumerable<RoomSubjectSchedule> Get()
        {
            return allRepository.RoomSubjectScheduleRepository.GetAll();
        }

        [HttpGet]
        [Route("/list")]
        public RoomSubjectSchedule Get([FromQuery]string departmentName)
        {
            return allRepository.RoomSubjectScheduleRepository.GetRoomSubjectSchedule(1);
            //return allRepository.RoomSubjectScheduleRepository.GetRoomSubjectList(departmentName);
        }

        [HttpGet]
        [Route("/semester/{semesterID}")]
        public IEnumerable<ViewRoomSubjectSchedule> GetRoomSubjectsScheduled(int semesterID, [FromQuery] string day) 
        {
            return allRepository.RoomSubjectScheduleRepository.GetRoomSubjectList(semesterID, day);
            //return allRepository.RoomSubjectScheduleRepository.GetRoomSubjectList(departmentName);
        }

        // GET api/<RoomSubjectScheduleController>/5
        [HttpGet("{id}")]
        public RoomSubjectSchedule Get(int id)
        {
            var a = DateTime.MinValue;

            var b = Convert.ToDateTime("Mon Jan 01 2001 10:31:00 GMT+0800 (Philippine Standard Time)");
            return allRepository.RoomSubjectScheduleRepository.GetByID(id);
        }

        // POST api/<RoomSubjectScheduleController>
        [HttpPost]
        public RoomSubjectSchedule Post([FromBody] RoomSubjectSchedule value)
        {
            var dept = allRepository.RoomSubjectScheduleRepository.Insert(value);
            allRepository.RoomSubjectScheduleRepository.SaveChanges();

            return dept;
        }

        // PUT api/<RoomSubjectScheduleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RoomSubjectSchedule value)
        {
            allRepository.RoomSubjectScheduleRepository.Update(id, value);
            allRepository.RoomSubjectScheduleRepository.SaveChanges();
        }

        // DELETE api/<RoomSubjectScheduleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            allRepository.RoomSubjectScheduleRepository.Delete(id);
            allRepository.RoomSubjectScheduleRepository.SaveChanges();
        }
    }
}
