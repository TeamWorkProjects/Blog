using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Post> Posts {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DbInMemory");
            //optionsBuilder.UseSqlServer("server=localhost;user=SA;password=Kleopatra2017$;database=Blog;trusted_connection=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
            .HasKey(k => k.PostId);
        }
    }
}