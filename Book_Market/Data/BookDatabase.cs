using Book_Market.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Market.Data
{
	public class BookDatabase:DbContext
	{
		public BookDatabase(DbContextOptions options) : base(options) { }

		public DbSet<Order> orders { get; set; }
		public DbSet<Product> products { get; set; }
		public DbSet<User> users { get; set; }
	}
}
