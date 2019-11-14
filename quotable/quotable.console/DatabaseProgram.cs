using System;
using System.Threading.Tasks;
using quotable.core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using quotable.core.data;

namespace quotable.console
{
    /// <summary>
    /// Makes the database do something
    /// </summary>
    class DatabaseProgram
    {

        static async Task Main(string[] args)
        {
            var container = new ServiceCollection();

            container.AddDbContext<QuotableContext>(options => options.UseSqlite("Data Source=quotable.db"), ServiceLifetime.Transient);

            var provider = container.BuildServiceProvider();

            using (var context = provider.GetService<QuotableContext>())
            {
                await context.Database.EnsureDeletedAsync();

                var dbDidntExist = await context.Database.EnsureCreatedAsync();

                if (dbDidntExist)
                {
                    await PopulateDatabase(context);
                }
            }

            using (var context = provider.GetService<QuotableContext>())
            {
                var quotes = context.Quotes
                                        .Include(d => d.QuoteAuthor)
                                        .ThenInclude(x => x.Author);

                foreach (var quote in quotes)
                {
                    Console.WriteLine($"quote.id = {quote.Id}");
                    Console.WriteLine($"quote.title = {quote.Title}");

                    foreach (var author in quote.Authors)
                    {
                        Console.WriteLine($"quote.author.id = {author.Id}");
                        Console.WriteLine($"quote.author.firstname = {author.FirstName}");
                        Console.WriteLine($"quote.author.firstname = {author.LastName}");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        private static async Task PopulateDatabase(QuotableContext context)
        {
            var author1 = new Author()
            {
                FirstName = "Last Of Us",
                LastName = "NaughtyDog"
            };
            var author2 = new Author()
            {
                FirstName = "Hunt Showdown",
                LastName = "Crytek"
            };
            var author3 = new Author()
            {
                FirstName = "Fallout",
                LastName = "Bethesda/Obsidean"
            };
            var author4 = new Author()
            {
                FirstName = "Oregon Trail",
                LastName = "MECC"
            };

            var quote1 = new Quote();
            quote1.Saying = "endure and survive";

            var quote2 = new Quote();
            quote2.Saying = "You Live to Hunt Another Day";

            var quote3 = new Quote();
            quote3.Saying = "Rise Up Damned Soul";

            var quote4 = new Quote();
            quote4.Saying = "War, War Never Changes";

            var quote5 = new Quote();
            quote5.Saying = "You have died of dysentery";

            var qa1 = new QuoteAuthor() { Quote = quote1, Author = author1 };
            var qa2 = new QuoteAuthor() { Quote = quote2, Author = author2 };
            var qa3 = new QuoteAuthor() { Quote = quote3, Author = author2 };
            var qa4 = new QuoteAuthor() { Quote = quote4, Author = author3 };
            var qa5 = new QuoteAuthor() { Quote = quote5, Author = author4 };

            context.AddRange(qa1, qa2, qa3, qa4, qa5);

            await context.SaveChangesAsync();
        }
    }
}
