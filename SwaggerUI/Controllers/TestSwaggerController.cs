using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestSwaggerController : ControllerBase
    {
        [HttpGet("test")]
        public OkObjectResult testSwapper()
        {
            return Ok("success");
        }

    }
}