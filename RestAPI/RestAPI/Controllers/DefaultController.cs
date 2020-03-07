using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("api/[controller]/{name}/{age}")]
        public string get(string name, string age)
        {
            return name + "/" + age;
        }
    }
}
