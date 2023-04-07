using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public FacultyController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<FacultyController>
        [HttpGet]
        public IEnumerable<Faculty> Get()
        {
            return allRepository.FacultyRepository.GetAll();
        }

        // GET api/<FacultyController>/5
        [HttpGet("{id}")]
        public Faculty Get(int id)
        {
            return allRepository.FacultyRepository.GetByID(id);
        }

        // POST api/<FacultyController>
        [HttpPost]
        public Faculty Post([FromBody] Faculty value)
        {
            var dept = allRepository.FacultyRepository.Insert(value);
            allRepository.FacultyRepository.SaveChanges();

            return dept;
        }

        // PUT api/<FacultyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Faculty value)
        {
            allRepository.FacultyRepository.Update(id, value);
            allRepository.FacultyRepository.SaveChanges();

        }

        // DELETE api/<FacultyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.FacultyRepository.GetByID(id);

            allRepository.FacultyRepository.Delete(foundToDelete);
            allRepository.FacultyRepository.SaveChanges();

        }
    }
}
