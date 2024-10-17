using Microsoft.EntityFrameworkCore;

namespace WebAppWithBlazor.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");  // Using in-memory database
        }
    }
}
