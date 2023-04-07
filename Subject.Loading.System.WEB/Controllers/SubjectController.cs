using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public SubjectController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<SubjectController>
        [HttpGet]
        public IEnumerable<LS.Model.Subject> Get()
        {
            return allRepository.SubjectRepository.GetAll();
        }

        // GET api/<SubjectController>/5
        [HttpGet("{id}")]
        public LS.Model.Subject Get(int id)
        {
            return allRepository.SubjectRepository.GetByID(id);
        }

        // POST api/<SubjectController>
        [HttpPost]
        public LS.Model.Subject Post([FromBody] LS.Model.Subject value)
        {
            var dept = allRepository.SubjectRepository.Insert(value);
            allRepository.SubjectRepository.SaveChanges();

            return dept;
        }

        // PUT api/<SubjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LS.Model.Subject value)
        {
            allRepository.SubjectRepository.Update(id, value);
            allRepository.SubjectRepository.SaveChanges();
        }

        // DELETE api/<SubjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.SubjectRepository.GetByID(id);

            allRepository.SubjectRepository.Delete(foundToDelete);
            allRepository.SubjectRepository.SaveChanges();
        }
    }
}
