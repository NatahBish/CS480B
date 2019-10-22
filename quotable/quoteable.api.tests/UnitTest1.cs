using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;
using System;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Tests the use of "quoteable.api"
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Unused as of Homework 2
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests the equivalent of getQuoteByID(id)
        /// </summary>
        [Test]
        public void getQuoteByIDTest()
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider();
            quoteController controller = new quoteController();

            var result = controller.Get(0);

            List<string> expected = new List<string>();
            string input = "0";
            expected.Add(input);
            expected.Add("endure and survive");
            expected.Add("-Ellie, Last of Us");

            Assert.AreEqual(expected, result.Value);

        }

        /// <summary>
        /// Tests the equivalent of getRandomQuote
        /// </summary>
        [Test]
        public void getRandomQuoteTest()
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider(new Random(1));
            randomController controller = new randomController();

            var result = controller.Get(simp);

            List<string> expected = new List<string>();
            string input = "1";
            expected.Add(input);
            expected.Add("You Live to Hunt Another Day");
            expected.Add("-HuntShowdown");

            Assert.AreEqual(expected, result.Value);

        }
    }
}