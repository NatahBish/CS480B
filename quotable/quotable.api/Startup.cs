using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using quotable.core;
using quotable.core.data;

namespace quotable.api
{
    /// <summary>
    /// Made by api creater
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Made by api creater
        /// </summary>
		/// <param name="configuration">The configuration for the application</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Made by api creater
        /// </summary>
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        /// <summary>
        /// Made by api creater
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<quotableDbContext>(options => options.UseSqlite(@"Data "))

            //services.AddSingleton<RandomQuoteProvider, SimpleRandomQutoeProvider>()

            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
            // setup to use a sqlite database
            services.AddDbContext<QuotableContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// <summary>
        /// Made by api creater
        /// </summary>
        /// <param name="app">The application builder</param>
		/// <param name="env">The hosting environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuotableContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                PopulateDatabase(context);
            }
        }

        /// <summary>
        /// Populates a database with a set of authors and quotes and combines them in a AuthorQuote too.
        /// </summary>
        private static void PopulateDatabase(QuotableContext context)
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
            var author5 = new Author()
            {
                FirstName = "S'chn T'gai",
                LastName = "Spock"
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

            var quote6 = new Quote();
            quote6.Saying = "Vulcan Pinch";

            var qa1 = new QuoteAuthor() { Quote = quote1, Author = author1 };
            var qa2 = new QuoteAuthor() { Quote = quote2, Author = author2 };
            var qa3 = new QuoteAuthor() { Quote = quote3, Author = author2 };
            var qa4 = new QuoteAuthor() { Quote = quote4, Author = author3 };
            var qa5 = new QuoteAuthor() { Quote = quote5, Author = author4 };
            var qa6 = new QuoteAuthor() { Quote = quote6, Author = author5 };

            context.AddRange(qa1, qa2, qa3, qa4, qa5, qa6);

            context.SaveChanges();
        }
    }
}
