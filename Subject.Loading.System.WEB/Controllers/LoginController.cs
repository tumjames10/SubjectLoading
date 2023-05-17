using LS.Model;
using LS.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Subject.Loading.System.WEB.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Subject.Loading.System.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IUserRepository _userRepository;
        public LoginController(IConfiguration config, IAllRepository allRepository)
        {
            _config = config;
            _userRepository = allRepository.UserRepository;
        }

        [HttpPost]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            var user = Authenticate(userLogin);
            if(user != null)
            {
                var token = GenerateToken(user);

                user.Token = token;
                return Ok(user);
            }

            return NotFound();
        }

        [HttpPost("/register")]

        public IActionResult Register([FromBody]UserModel userModel)
        {
            if (userModel == null)
                return BadRequest();

            User user = new User()
            {
                UserName = userModel.UserName,
                Password = userModel.Password,
                Role = userModel.Role,
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
                Role = user.Role
                
            };
        }
    }
}
