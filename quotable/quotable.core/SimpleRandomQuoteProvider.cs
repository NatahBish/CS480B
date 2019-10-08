using System;
using System.Collections.Generic;

namespace quotable.core
{
    public sealed class SimpleRandomQuoteProvider : RandomQuoteProvider
    {

        /// <summary>
        /// This is the String of quotes used to put into the IEnumerable.
        /// </summary>
        String[] myID = { "1","2", "3",
            "4", "5"  };
        String[] myQuotes = { "endure and survive", "You Live to Hunt Another Day", "Rise Up Damned Soul",
            "War, War Never Changes", "You have died of dysentery"  };
        String[] myAuthors = { "-Last of Us", "-Hunt Showdown", "-Hunt Showdown",
            "-Fallout", "-Oregon Trail"  };

        /// <summary>
        /// Unused but is the constructer for the class.
        /// </summary>
        public SimpleRandomQuoteProvider()
        {

        }

        /// <summary>
        /// This program takes the input from Program and returns the number of quotes requested from the hard-coded String List
        /// If the number is greater than teh number of quotes it will restart the list, so there is no crash.
        /// </summary>
        /// <param name="lng"></param>
        /// <returns> The IEnumerable need to access the quotes </returns>
        public IEnumerable<string> getQuote(long lng)
        {
            List<string> data = new List<string>();
            for(int i = 0; i<lng; i++)
            {
                data.Add(myID[i % myQuotes.Length]);
                data.Add(myQuotes[i % myQuotes.Length]);
                data.Add(myAuthors[i % myQuotes.Length]);
            }
            return data;

        }

    }
}
