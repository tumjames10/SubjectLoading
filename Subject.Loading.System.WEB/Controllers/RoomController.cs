using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public RoomController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<RoomController>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return allRepository.RoomRepository.GetAll();
        }

        // GET api/<RoomController>/5
        [HttpGet("{id}")]
        public Room Get(int id)
        {
            return allRepository.RoomRepository.GetByID(id);
        }

        // POST api/<RoomController>
        [HttpPost]
        public Room Post([FromBody] Room value)
        {
            var dept = allRepository.RoomRepository.Insert(value);
            allRepository.RoomRepository.SaveChanges();

            return dept;
        }

        // PUT api/<RoomController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Room value)
        {
            allRepository.RoomRepository.Update(id, value);
            allRepository.RoomRepository.SaveChanges();
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var foundToDelete = allRepository.RoomRepository.GetByID(id);

            allRepository.RoomRepository.Delete(foundToDelete);
            allRepository.RoomRepository.SaveChanges();
        }
    }
}
