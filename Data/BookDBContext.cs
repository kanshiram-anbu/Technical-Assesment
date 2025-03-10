using Microsoft.EntityFrameworkCore;
using SampleMVCApplication.Models;

namespace SampleMVCApplication.Data
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> option) : base(option) { }

        public DbSet<Books> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure your table mappings are correct
            modelBuilder.Entity<Books>().ToTable("Books");
        }
    }
}
