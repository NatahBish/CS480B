using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests the equivalent of getQuoteByID(id)
        /// </summary>
        [Test]
        public void Test1()
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
        /// Tests the equivalent of getRandomQuote(id)
        /// </summary>
        [Test]
        public void Test2()
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