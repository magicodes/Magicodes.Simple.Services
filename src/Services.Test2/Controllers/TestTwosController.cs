using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magicodes.Simple.Services.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Services.Test2.Controllers
{
    [Route("api2/[controller]")]
    [ApiController]
    public class TestTwosController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<AbpTenants>> Get()
        {
            MagicodesAdminContext MagicodesAdminContext = new MagicodesAdminContext();
            return MagicodesAdminContext.AbpTenants.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
