using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;

namespace quotable.api.Controllers
{
    /// <summary>
    /// Used to get a random quote.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class randomController : ControllerBase
    {
        SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider();

        /// <summary>
        /// Completes the equivalent of "getRandomQuote"
        /// </summary>
        /// <returns>IEnumerbale string but into the api </returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(SimpleRandomQuoteProvider simp)
        {
            return simp.getRandomQuote().ToList();
        }

        /// <summary>
        /// Completes the equivalent of "getQuoteByID(id)"
        /// </summary>
        /// <returns>IEnumerbale string but into the api </returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return simp.getQuoteByID(id.ToString()).ToList();
        }

        /// <summary>
        /// Unused as of HomeWork 2
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// Unused as of HomeWork 2
        /// </summary>
        /// <param name="id"></param>
        /// /// <param name="value"></param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// Unused as of HomeWork 2
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
