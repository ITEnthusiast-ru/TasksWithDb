using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace TasksWithDb
{
    public class ApplicationDbContext:DbContext
    {
        DbSet<User> Users { get; set; }
        public ApplicationDbContext() =>Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = helloApp.db");
        }
    }
}
