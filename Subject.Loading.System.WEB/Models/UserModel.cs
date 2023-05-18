using LS.Model;

namespace Subject.Loading.System.WEB.Models
{
    public class UserModel
    {
        public int? UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string? Role { get; set; }

        public string? Token { get; set; }

        public DateTime? ExpiresIn { get; set; }

        public int? FacultyID { get; set;  }

        public Faculty? Faculty { get; set; }
    }
}
