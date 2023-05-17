using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public RequestController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<RequestController>
        [HttpGet]
        public IEnumerable<Request> Get()
        {
            return allRepository.RequestRepository.GetAll();
        }

        // GET api/<RequestController>/5
        [HttpGet("{id}")]
        public Request Get(int id)
        {
            return allRepository.RequestRepository.GetByID(id);
        }

        // POST api/<RequestController>
        [HttpPost]
        public Request Post([FromBody] Request value)
        {
            var dept = allRepository.RequestRepository.Insert(value);
            allRepository.RequestRepository.SaveChanges();

            return dept;
        }

        // PUT api/<RequestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Request value)
        {
            allRepository.RequestRepository.Update(id, value);
            allRepository.RequestRepository.SaveChanges();
        }

        // DELETE api/<RequestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            allRepository.RequestRepository.Delete(id);
            allRepository.RequestRepository.SaveChanges();
        }
    }
}
