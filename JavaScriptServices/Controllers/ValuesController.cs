using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace JavaScriptServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INodeServices _nodeServices;

        public ValuesController(INodeServices nodeServices)
        {
            _nodeServices = nodeServices;
        }


        // GET api/values
        [HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        public async Task<string> Get()
        {
            // return new string[] { "value1", "value2" };
            return await _nodeServices.InvokeAsync<string>("./scripts/js/greeter", "Joseph", "Woodward");

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
