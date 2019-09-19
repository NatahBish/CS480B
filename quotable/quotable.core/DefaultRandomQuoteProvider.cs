using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    class DefaultRandomQuoteProvider : RandomQuoteProvider
    {
        public Guid ID => throw new NotImplementedException();

        public long ComputeNumber(long input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getQuote(long lng)
        {
            throw new NotImplementedException();
        }
    }
}
