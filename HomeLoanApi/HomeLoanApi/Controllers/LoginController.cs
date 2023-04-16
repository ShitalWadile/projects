using HomeLoanApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace HomeLoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        public LoginController(IConfiguration configuration)
        {
            _config = configuration;
        }

        private User AuthenticateUser(User user)
        {
            User _user= null;
            if(user.Email=="admin@gmail.com" && user.Password=="admin@123")
            { 
             _user =new Models.User { Email ="shitalkw001@gmail.com", Password ="shital@123"};    
            
            }
            return _user;
        }

        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Audience"]));
            var credentials=new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            var token=new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"],null,
                expires:DateTime.Now.AddMinutes(1),signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(User user)
        {
            IActionResult response = Unauthorized();
            var user_=AuthenticateUser(user);
            if (user_!=null) 
            { 
            var token =GenerateToken(user_);
                response=Ok(new { token=token});
            }
            return response;
        }
    }
}
