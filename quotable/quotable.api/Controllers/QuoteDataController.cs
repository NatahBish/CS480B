﻿using Microsoft.AspNetCore.Mvc;
using quotable.api.Models;
using quotable.core.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Controllers
{
    /// <summary>
	/// API controller for the '/quotes' resource.
	/// </summary>
	[Route("api/[controller]")]
    [ApiController]
    public class QuoteDataController : ControllerBase
    {
        private readonly QuotableContext _context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">The database context to data access.</param>
        public QuoteDataController(QuotableContext context)
        {
            _context = context;
        }

        // GET api/values
        /// <summary>
        /// Returns all the quotes.
        /// </summary>
        /// <returns>All the quotes.</returns>
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return from quote in _context.Quotes
                   select new Quote()
                   {
                       Saying = quote.Saying
                   };
        }

        // GET api/values/5
        /// <summary>
        /// Gets a specific quote.
        /// </summary>
        /// <param name="id">The id of the quote to get.</param>
        /// <returns>The quote.</returns>
        [HttpGet("{id}")]
        public ActionResult<Quote> Get(long id)
        {
            var quote = _context.Quotes.SingleOrDefault(d => d.Id == id);

            if (quote == null)
            {
                return NotFound();
            }

            return new Quote()
            {
                Saying = quote.Saying
            };
        }
    }
}
