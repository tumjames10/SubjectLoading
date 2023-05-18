using LS.Model;
using LS.Repository;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Subject.Loading.System.WEB.Models;

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

        [HttpGet("request")]
        public List<FacultyRequest> GetFacultyRequest()
        {
            List<FacultyRequest> retVal = new List<FacultyRequest>();
            var listUnApproved = allRepository.RequestRepository.GetAll().Where(j => !j.IsApproved).ToList();

            foreach (var item in listUnApproved)
            {
                FacultyRequest value = new FacultyRequest();

                value.Faculty = allRepository.FacultyRepository.GetByID(item.RequesterID);

                var semester = allRepository.SemesterRepository.GetByID(item.SemesterID);

                value.SemesterName = semester.SemesterName;
                value.SemesterID = semester.SemesterID;
                value.RequestID = item.RequestID;

                retVal.Add(value);
            }

            return retVal;
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

            allRepository.FacultyRepository.Delete(id);
            allRepository.FacultyRepository.SaveChanges();

        }
    }
}
