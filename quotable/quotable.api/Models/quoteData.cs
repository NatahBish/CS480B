using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    /// <summary>
    /// Unused if needed will become used and I will face the consequences of not using it to start with.
    /// </summary>
    public class quoteData
    {
        /// <summary>
        /// The quotes ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The quote
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// Author of the quote
        /// </summary>
        public string Author { get; set; }
    }
}
