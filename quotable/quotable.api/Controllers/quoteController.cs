using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class quoteController : ControllerBase
    {

        String[] myID = { "0","1", "2",
            "3", "4"  };
        String[] myQuote = { "endure and survive", "You Live to Hunt Another Day", "Rise Up Damned Soul",
            "War, War Never Changes", "You have died of dysentery"  };
        String[] myAuthor = { "-Last of Us", "-Hunt Showdown", "-Hunt Showdown",
            "-Fallout", "-Oregon Trail"  };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<string> data = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                data.Add(myID[i % myID.Length]);
                data.Add(myQuote[i % myQuote.Length]);
                data.Add(myAuthor[i % myAuthor.Length]);
                data.Add(System.Environment.NewLine);
            }
            return data;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            string lookup = "-" + myID[id] + System.Environment.NewLine + "-" + myQuote[id] + System.Environment.NewLine + "-" + myAuthor[id] + System.Environment.NewLine;
            return lookup;
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
