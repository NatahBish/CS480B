using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core.data
{
	class QuotableContext : DbContext
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public QuotableContext(DbContextOptions options) : base(options)
		{

		}

		/// <summary>
		/// Used to access documents in the database.
		/// </summary>
		public DbSet<Quote> Quote { get; set; }

		/// <summary>
		/// Used to access authors in the database.
		/// </summary>
		public DbSet<Author> Authors { get; set; }

        /// <inheritdoc/>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteAuthor>().HasKey(x => new { x.QuoteId, x.AuthorId });
        }
    }
}
