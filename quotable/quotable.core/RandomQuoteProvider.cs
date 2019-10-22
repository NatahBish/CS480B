using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Defines a Random Quote Provider
    /// </summary>
    public interface RandomQuoteProvider
    {
        /// <summary>
        /// Creates the IEnumberable sequence.
        /// </summary>
        /// <param name="lng"></param>
        /// <returns> The IEnumerable sequence for the lng. </returns>
        IEnumerable<string> getQuote(long lng);

        /// <summary>
        /// Used to add a quote to the list/IEnumerable
        /// </summary>
        /// <param name="iD"></param>
        /// <param name="quote"></param>
        /// <param name="author"></param>
        void addToQuoteList(string iD, string quote, string author);
        
        /// <summary>
        /// Gets all quotes from the list.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> getAllQuotes();

        /// <summary>
        /// Gets a quote based on the ID given.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        IEnumerable<string> getQuoteByID(string ID);

        /// <summary>
        /// Gets a random quote from the list.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> getRandomQuote();
    }
}
