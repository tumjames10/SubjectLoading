using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorScheduleController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public InstructorScheduleController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<InstructorScheduleController>
        [HttpGet]
        public IEnumerable<InstructorSchedule> Get()
        {
            return allRepository.InstructorScheduleRepository.GetAll();
        }

        // GET api/<InstructorScheduleController>/5
        [HttpGet("{id}")]
        public InstructorSchedule Get(int id)
        {
            return allRepository.InstructorScheduleRepository.GetByID(id);
        }

        [HttpGet("schedules")]
        public IEnumerable<InstructorSchedule> GetInstructorSchedules([FromQuery]int facultyId, [FromQuery]int semesterID)
        {
            return allRepository.InstructorScheduleRepository.GetInstructorSchedule(facultyId, semesterID);
        }


        // POST api/<InstructorScheduleController>
        [HttpPost]
        public InstructorSchedule Post([FromBody] InstructorSchedule value)
        {
            var dept = allRepository.InstructorScheduleRepository.Insert(value);
            allRepository.InstructorScheduleRepository.SaveChanges();

            return dept;
        }

        // PUT api/<InstructorScheduleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] InstructorSchedule value)
        {
            allRepository.InstructorScheduleRepository.Update(id, value);
            allRepository.InstructorScheduleRepository.SaveChanges();
        }

        // DELETE api/<InstructorScheduleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            allRepository.InstructorScheduleRepository.Delete(id);
            allRepository.InstructorScheduleRepository.SaveChanges();
        }
    }
}
