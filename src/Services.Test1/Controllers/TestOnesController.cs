using System;
using System.Collections.Generic;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace Services.Test1.Controllers
{
    [Route("api1/[controller]")]
    [ApiController]
    public class TestOnesController : ControllerBase
    {
        private readonly ICapPublisher _capBus;

        public TestOnesController(ICapPublisher capPublisher)
        {
            _capBus = capPublisher;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _capBus.Publish("services.test1.show.time", DateTime.Now);
            return new string[] { "TestOnes_value1", "TestOnes_value2" };
        }

        [HttpGet]
        [Route("health")]
        public ActionResult<string> Health()
        {
            return "Health!!!!!";
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
