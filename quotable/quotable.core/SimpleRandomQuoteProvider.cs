using System;
using System.Collections.Generic;

namespace quotable.core
{
    public sealed class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        private readonly Guid guid = Guid.NewGuid();

        public SimpleRandomQuoteProvider()
        {
        }
        
        public long ComputeNumber(long input)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> getQuote(long lng)
        {
            long[] data = {1, 2, 3};
            return data;

        }


        public Guid ID
        {
            get { return guid; }
        }

    }
}
