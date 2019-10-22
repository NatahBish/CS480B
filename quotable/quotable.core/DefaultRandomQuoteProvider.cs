using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Unsucsessfull creation of a quote provider, left here as a reminder
    /// </summary>
    public sealed class DefaultRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// Unsucessful
        /// </summary>
        /// <param name="iString"></param>
        public DefaultRandomQuoteProvider(IEnumerable<String> iString)
        {
            IEnumerable<String> diString = iString;
        }

        /// <summary>
        /// Unused
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="quote"></param>
        /// <param name="autho"></param>
        public void addToQuoteList(string iD, string quote, string autho)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unused
        /// </summary>
        public IEnumerable<string> getAllQuotes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unused
        /// </summary>
        /// <param name="lng"></param>
        public IEnumerable<string> getQuote(long lng)
        {


            return null;
        }

        /// <summary>
        /// Unused
        /// </summary>
        public IEnumerable<string> getQuoteByID(string ID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unused
        /// </summary>
        public IEnumerable<string> getRandomQuote()
        {
            throw new NotImplementedException();
        }
    }
}
