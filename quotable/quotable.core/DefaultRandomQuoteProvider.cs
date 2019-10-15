using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public sealed class DefaultRandomQuoteProvider : RandomQuoteProvider
    {
        public DefaultRandomQuoteProvider(IEnumerable<String> iString)
        {
            IEnumerable<String> diString = iString;
        }

        public void addToQuoteList(string iD, string quote, string autho)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getAllQuotes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getQuote(long lng)
        {


            return null;
        }

        public IEnumerable<string> getQuoteByID(string ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getRandomQuote()
        {
            throw new NotImplementedException();
        }
    }
}
