using quotable.core;
using System;
using System.Collections.Generic;

namespace quotable.console
{
    class Program
    {
        /// <summary>
        /// Starts the program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider("iD","hi","writer");
            string input = "";
            simp.getQuote(1);

            ///Helps answer Question 4, we did not learn how to read from a file.
            String[] myquotes = { "endure and survive -Last of Us", "You Live to Hunt Another Day -Hunt Showdown", "Rise Up Damned Soul -Hunt Showdown" };
            List<string> data = new List<string>();
            for (int i = 0; i < myquotes.Length; i++)
            {
                data.Add(myquotes[i]);
            }
            DefaultRandomQuoteProvider def = new DefaultRandomQuoteProvider(data);

            ///This is where input starts to be needed, when the user puts in "exit" the code will end, else it will return the hard-coded quotes.
            while (!input.Equals("exit"))
            {
                Console.WriteLine("Please tell me how many quotes you want, or type 'exit' to end the program");
                input = Console.ReadLine();
                long lng = 0;
                bool isAlong = long.TryParse(input, out lng);
                if (isAlong)
                {
                    IEnumerable<string> enumString = simp.getQuote(lng);

                    foreach (var str in enumString)
                    {
                        Console.WriteLine(str);
                    }
                    Console.WriteLine("");

                }
                else if (input.Equals("exit")) { }
                else
                {
                    Console.WriteLine("Please enter a NUMBER!!!");
                }
            }
            //Console.WriteLine("This is the DefaultRandom Quote Provider we did not go over reading from a file");
            //def.getQuote(0);

            //foreach (var str in )
            //{
            //    Console.WriteLine(str);
            //}
        }
    }
}
