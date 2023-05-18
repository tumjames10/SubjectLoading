using LS.Model;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Subject.Loading.System.WEB.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        private readonly IFacultyRepository _facultyRepository;
        public LoginController(IConfiguration config, IAllRepository allRepository)
        {
            _config = config;
            _userRepository = allRepository.UserRepository;
            _facultyRepository = allRepository.FacultyRepository;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);
            if(user != null)
            {
                var token = GenerateToken(user);

                user.ExpiresIn = DateTime.Now.AddMinutes(60);
                user.Token = token;
                return Ok(user);
            }

            return NotFound();
        }

        [HttpPost()]
        [Route("register")]
        public IActionResult Register([FromBody]UserModel userModel)
        {
            if (userModel == null)
                return BadRequest();

            var faculty = this._facultyRepository.Insert(userModel.Faculty);
            this._facultyRepository.SaveChanges();

            User user = new User()
            {
                UserName = userModel.UserName,
                Password = userModel.Password,
                Role = userModel.Role,
                FacultyID = faculty.FacultyId
            };
            
            var retVal  = _userRepository.Register(user);

            return Ok(retVal);
        }

        private string GenerateToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.UserName),
                new Claim(ClaimTypes.Role,user.Role)
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        private UserModel Authenticate(UserLogin userlogin)
        {
            var user = this._userRepository.Auntheticate(userlogin.UserName, userlogin.Password);

            if (user == null)
                NotFound();

            return new UserModel()
            {
                UserName = user.UserName,
                Role = user.Role,
                UserID = user.UserID ,
                FacultyID = user.FacultyID
            };
        }
    }
}
