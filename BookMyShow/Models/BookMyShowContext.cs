using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BookMyShow.Models
{
    public class BookMyShowContext : DbContext
    {
        public BookMyShowContext(DbContextOptions<BookMyShowContext> options)
            : base(options)
        {
        }

        public DbSet<Theatre> TodoItems { get; set; } = null!;
    }
}
