using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectScheduleController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public SubjectScheduleController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<SubjectScheduleController>
        [HttpGet]
        public IEnumerable<SubjectSchedule> Get()
        {
            return allRepository.SubjectScheduleRepository.GetAll();
        }

        // GET api/<SubjectScheduleController>/5
        [HttpGet("{id}")]
        public SubjectSchedule Get(int id)
        {
            return allRepository.SubjectScheduleRepository.GetByID(id);
        }

        // POST api/<SubjectScheduleController>
        [HttpPost]
        public SubjectSchedule Post([FromBody] SubjectSchedule value)
        {
            var dept = allRepository.SubjectScheduleRepository.Insert(value);
            allRepository.SubjectScheduleRepository.SaveChanges();

            return dept;
        }

        // PUT api/<SubjectScheduleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SubjectSchedule value)
        {
            allRepository.SubjectScheduleRepository.Update(id, value);
            allRepository.SubjectScheduleRepository.SaveChanges();
        }

        // DELETE api/<SubjectScheduleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.SubjectScheduleRepository.GetByID(id);

            allRepository.SubjectScheduleRepository.Delete(foundToDelete);
            allRepository.SubjectScheduleRepository.SaveChanges();
        }
    }
}
