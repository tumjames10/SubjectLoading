using LS.Model;

namespace Subject.Loading.System.WEB.Models
{
    public class FacultyRequest
    {
        public Faculty Faculty { get; set; }

        public int RequestID { get; set; }

        public int SemesterID { get; set; }
        
        public string SemesterName { get; set; }
        
    }
}
