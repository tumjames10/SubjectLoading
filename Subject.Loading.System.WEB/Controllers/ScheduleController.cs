using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public ScheduleController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<ScheduleController>
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
            return allRepository.ScheduleRepository.GetAll();
        }

        // GET api/<ScheduleController>/5
        [HttpGet("{id}")]
        public Schedule Get(int id)
        {
            return allRepository.ScheduleRepository.GetByID(id);
        }

        // POST api/<ScheduleController>
        [HttpPost]
        public Schedule Post([FromBody] Schedule value)
        {
            var dept = allRepository.ScheduleRepository.Insert(value);
            allRepository.ScheduleRepository.SaveChanges();

            return dept;
        }

        // PUT api/<ScheduleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Schedule value)
        {
            allRepository.ScheduleRepository.Update(id, value);
            allRepository.ScheduleRepository.SaveChanges();
        }

        // DELETE api/<ScheduleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.ScheduleRepository.GetByID(id);

            allRepository.ScheduleRepository.Delete(foundToDelete);
            allRepository.ScheduleRepository.SaveChanges();
        }
    }
}
