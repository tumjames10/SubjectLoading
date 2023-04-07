using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public SemesterController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<SemesterController>
        [HttpGet]
        public IEnumerable<Semester> Get()
        {
            return allRepository.SemesterRepository.GetAll();
        }

        // GET api/<SemesterController>/5
        [HttpGet("{id}")]
        public Semester Get(int id)
        {
            return allRepository.SemesterRepository.GetByID(id);
        }

        // POST api/<SemesterController>
        [HttpPost]
        public Semester Post([FromBody] Semester value)
        {
            var dept = allRepository.SemesterRepository.Insert(value);
            allRepository.SemesterRepository.SaveChanges();

            return dept;
        }

        // PUT api/<SemesterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Semester value)
        {
            allRepository.SemesterRepository.Update(id, value);
            allRepository.SemesterRepository.SaveChanges();

        }

        // DELETE api/<SemesterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.SemesterRepository.GetByID(id);

            allRepository.SemesterRepository.Delete(foundToDelete);
            allRepository.SemesterRepository.SaveChanges();

        }
    }
}
