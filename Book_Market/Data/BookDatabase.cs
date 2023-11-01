using Microsoft.EntityFrameworkCore;

namespace Book_Market.Data
{
	public class BookDatabase:DbContext
	{
		public BookDatabase(DbContextOptions options) : base(options) { }

	}
}
