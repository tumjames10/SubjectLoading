using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles /*="Admin")]*/
    public class DepartmentController : ControllerBase
    {
        private readonly IAllRepository allRepository;

        public DepartmentController(IAllRepository allRep)
        {
            allRepository = allRep;
        }

        // GET: api/<DepartmentController>
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return allRepository.DepartmentRepository.GetAll();
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return allRepository.DepartmentRepository.GetByID(id);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public Department Post([FromBody] Department value)
        {
            var dept = allRepository.DepartmentRepository.Insert(value);
            allRepository.DepartmentRepository.SaveChanges();

            return dept;
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Department value)
        {
            allRepository.DepartmentRepository.Update(id, value);
            allRepository.DepartmentRepository.SaveChanges();
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            allRepository.DepartmentRepository.Delete(id);
            allRepository.DepartmentRepository.SaveChanges();
        }
    }
}
