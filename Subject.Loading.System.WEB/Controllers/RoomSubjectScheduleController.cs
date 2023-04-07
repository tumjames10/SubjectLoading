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

        // GET api/<RoomSubjectScheduleController>/5
        [HttpGet("{id}")]
        public RoomSubjectSchedule Get(int id)
        {
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
            var foundToDelete = allRepository.RoomSubjectScheduleRepository.GetByID(id);

            allRepository.RoomSubjectScheduleRepository.Delete(foundToDelete);
            allRepository.RoomSubjectScheduleRepository.SaveChanges();
        }
    }
}
