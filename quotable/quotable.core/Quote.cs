using System.Collections.Generic;
using System.Linq;


namespace quotable.core
{
    /// <summary>
    /// Quote that will need an author
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The title of the quote.
        /// </summary>
        public string Saying { get; set; }

        /// <summary>
        /// The collection of authors of the document
        /// </summary>
        //[NotMapped]
        public IEnumerable<Author> Authors => from x in QuoteAuthor select x.Author;

        /// <summary>
        /// The relation of document to author
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; } = new List<QuoteAuthor>();
    }
}
