using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Defines a Random Quote Provider
    /// </summary>
    interface RandomQuoteProvider
    {
        /// <summary>
        /// Creates the IEnumberable sequence.
        /// </summary>
        /// <param name="lng"></param>
        /// <returns> The IEnumerable sequence for the lng. </returns>
        IEnumerable<string> getQuote(long lng);
        void addToQuoteList(string iD, string quote, string autho);
        IEnumerable<string> getAllQuotes();
        IEnumerable<string> getQuoteByID(string ID);
    }
}
