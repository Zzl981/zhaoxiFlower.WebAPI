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
    public class RegisterController : ControllerBase
    {
        [HttpPost]
        public UserModel Register([FromBody] UserModel user)
        {
            UserModel Userinfo = new UserModel() ;
            //Userinfo = user;
            Userinfo.Username = user.Username;
            Userinfo.Issuccess = true;
            return Userinfo;
        }
    }
}
