using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class quoteControllerV2 : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "endure and survive -Last of Us", "You Live to Hunt Another Day -Hunt Showdown", "Rise Up Damned Soul -Hunt Showdown",
            "War, War Never Changes -Fallout", "You have died of dysentery -Oregon Trail" };
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
