using NUnit.Framework;
using quotable.core;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Tests quoteable.core
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Unused
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests SimpleRandomQuoteProvider GetQuoteByID
        /// </summary>
        [Test]
        public void getQuoteByIDTest()
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider();
            List<string> expected = new List<string>();
            string input = "0";
            expected.Add("0");
            expected.Add("endure and survive");
            expected.Add("-Ellie, Last of Us");

            IEnumerable<string> actual = simp.getQuoteByID(input);

            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Tests SimpleRandomQuoteProvider GetAllQuotes
        /// </summary>
        [Test]
        public void getAllQuotesTest()
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider();
            List<string> expected = new List<string>();
            expected.Add("0");
            expected.Add("endure and survive");
            expected.Add("-Ellie, Last of Us");
            expected.Add("");
            expected.Add("1");
            expected.Add("You Live to Hunt Another Day");
            expected.Add("-HuntShowdown");
            expected.Add("");
            expected.Add("2");
            expected.Add("Rise Up Damned Soul");
            expected.Add("-HuntShowdown");
            expected.Add("");
            expected.Add("3");
            expected.Add("War, War Never Changes");
            expected.Add("-Fallout");
            expected.Add("");
            expected.Add("4");
            expected.Add("You have died of dysentery");
            expected.Add("-Oregon Trail");
            expected.Add("");

            IEnumerable<string> actual = simp.getAllQuotes();


            Assert.AreEqual(expected, actual);

        }
    }
}