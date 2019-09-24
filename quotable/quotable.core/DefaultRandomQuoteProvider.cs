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
        public IEnumerable<string> getQuote(long lng)
        {


            return null;
        }
    }
}
