using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpPost]
        public string Post([FromBody] PostRecieve postRecieve )
        {
            var name = postRecieve.MyName;
            var age = postRecieve.MyAge;
            var city = postRecieve.MyCity;

            return name + "/" + age + "/" + city;
        }

    }
}
