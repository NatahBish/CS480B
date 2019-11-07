using System;
using System.Collections.Generic;

namespace quotable.core
{
    /// <summary>
    /// Simplist Quote Provider for homework 0 and beyond.
    /// </summary>
    public sealed class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        List<string> data = new List<string>();
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
        /// teachers way of using a random
        /// </summary>
        public Random RNG { get; }

        /// <summary>
        /// Unused but is the constructer for the class.
        /// </summary>
        public SimpleRandomQuoteProvider(string iD, string quote, string author)
        {
            data.Add(iD);
            data.Add(quote);
            data.Add(author);
            data.Add("");
        }

        /// <summary>
        /// Constructor that creates a generic SimpleRandomQuoteProvider
        /// </summary>
        public SimpleRandomQuoteProvider()
        {
            addToQuoteList("0", "endure and survive", "-Ellie, Last of Us");
            addToQuoteList("1", "You Live to Hunt Another Day", "-HuntShowdown");
            addToQuoteList("2", "Rise Up Damned Soul", "-HuntShowdown");
            addToQuoteList("3", "War, War Never Changes", "-Fallout");
            addToQuoteList("4", "You have died of dysentery", "-Oregon Trail");

            RNG = new Random();
        }

        /// <summary>
        /// teachers way of using a random
        /// </summary>
        public SimpleRandomQuoteProvider(Random rng) : this()
        {
            this.RNG = rng;
        }

        /// <summary>
        /// This program takes the input from Program and returns the number of quotes requested from the hard-coded String List
        /// If the number is greater than teh number of quotes it will restart the list, so there is no crash.
        /// </summary>
        /// <param name="iD">ID in string format for easy printing</param>
        /// <param name="quote">quote</param>
        /// <param name="author">author</param>
        /// <returns> The IEnumerable need to access the quotes </returns>
        public void addToQuoteList(string iD, string quote, string author)
        {
            bool notUsed = true;
            for (int i = 0; i > data.Count; i++)
            {
                if (iD.Equals(data[i]))
                {
                    notUsed = false;
                }
            }
            if (notUsed)
            {
                data.Add(iD);
                data.Add(quote);
                data.Add(author);
                data.Add("");
            }

        }

        /// <summary>
        /// Only used to test before I implement something
        /// </summary>
        /// <param name="lng"></param>
        /// <returns> An Ienumerable used to test before we started using NUnit tests </returns>
        public IEnumerable<string> getQuote(long lng)
        {
            int answer1 = (3 % 3);
            int answer2 = (0 % 3);
            int answer3 = (6 % 3);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            return data;
            //List<string> data = new List<string>();
            //for (int i = 0; i < lng; i++)
            //{
            //    data.Add(myID[i % myQuotes.Length]);
            //    data.Add(myQuotes[i % myQuotes.Length]);
            //    data.Add(myAuthors[i % myQuotes.Length]);
            //}
            //return data;
        }

        /// <summary>
        /// Gets a Quote by the string ID which must be a number.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns> IEnumerable<string> needed that has one ID, quote, and author </string></returns>
        public IEnumerable<string> getQuoteByID(string ID)
        {
            List<string> quote = new List<string>();
            bool isNumeric = false;
            if (isNumeric = int.TryParse(ID, out int n))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (ID.Equals(data[i]))
                    {
                        //Console.WriteLine("got inside getQuoteByID if");
                        quote.Add(data[i]);
                        quote.Add(data[i + 1]);
                        quote.Add(data[i + 2]);
                        return quote;
                    }
                }
            }
            else
            {
                quote.Add("That is not a valid ID");
                return quote;
            }
            quote.Add("That is not a valid ID");
            return quote;
        }

        /// <summary>
        /// Returns all quotes in the object
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> getAllQuotes()
        {
            return data;
        }

        /// <summary>
        /// Returns a random quote from the object, including it's ID, quote, and author, not the space between each object.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> getRandomQuote()
        {
            Random rand = RNG;// new Random();
            int input = rand.Next(0, (data.Count / 4));
            string inputS = input.ToString();

            List<string> quote = new List<string>();
            for (int i = 0; i < data.Count; i++)
            {
                if (inputS.Equals(data[i]))
                {
                    quote.Add(data[i]);
                    quote.Add(data[i + 1]);
                    quote.Add(data[i + 2]);
                    return quote;
                }
            }
            quote.Add("The random number used an invalid random number.");
            return quote;

        }
    }
}
