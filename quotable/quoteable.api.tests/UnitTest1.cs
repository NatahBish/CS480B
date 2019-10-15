using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            SimpleRandomQuoteProvider simp = new SimpleRandomQuoteProvider();
            SimpleRandomQuoteProvider controller = new quoteController();



            }
    }
}