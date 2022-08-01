using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zhaoxiFlower.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public Login Register([FromBody] Login user)
        {
            Login login = new Login();
            //Userinfo = user;
            login.Username = user.Username;
            login.Issuccess = true;
            return login;
        }
    }
}
