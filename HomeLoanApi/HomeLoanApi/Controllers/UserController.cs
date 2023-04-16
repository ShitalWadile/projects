using HomeLoanApi.Models;
using HomeLoanApi.Models.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace HomeLoanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {

        private readonly IConfiguration _config;
        public readonly HomeLoanContext _context;
        public UserController(IConfiguration config, HomeLoanContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("CreateUser")]
        public IActionResult Create(Registration Reg)
        {
            if (_context.Register.Where(m => m.Email == Reg.Email && m.PWD==Reg.PWD).FirstOrDefault() != null)
            {
                return Ok("Already Exists");
            }
            //Reg.MemberSince = DateTime.Now;
            _context.Register.Add(Reg);
            _context.SaveChanges();
            return Ok("Sucess");
        }

        //[httppost("loginuser")]
        //public iactionresult login(registration registration)
        //{
        //    var useravailable = _context.register.where(u => u.email == registration.email && u.pwd == registration.pwd).firstordefault();

        //    if (useravailable != null)
        //    {
        //        return ok("sucess");
        //    }
        //    return ok("failture");
        //}

        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with Jwt";

        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Authenticated with Jwt";
        }

        [Authorize]
        [HttpPost]

        public string AddUser(User user)
        {
            return "User added with username" + user.Email;
        }

    }
        
    }


