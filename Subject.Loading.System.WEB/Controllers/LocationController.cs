using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public LocationController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<LocationController>
        [HttpGet]
        public IEnumerable<Location> Get()
        {
            return allRepository.LocationRepository.GetAll();
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public Location Get(int id)
        {
            return allRepository.LocationRepository.GetByID(id);
        }

        // POST api/<LocationController>
        [HttpPost]
        public Location Post([FromBody] Location value)
        {
            var dept = allRepository.LocationRepository.Insert(value);
            allRepository.LocationRepository.SaveChanges();

            return dept;
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Location value)
        {
            allRepository.LocationRepository.Update(id, value);
            allRepository.LocationRepository.SaveChanges();
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.LocationRepository.GetByID(id);

            allRepository.LocationRepository.Delete(foundToDelete);
            allRepository.LocationRepository.SaveChanges();
        }
    }
}
