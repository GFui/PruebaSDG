using Microsoft.EntityFrameworkCore;
using PruebaSDG.Models;

namespace PruebaSDG.Data
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options) { }

        public DbSet<CountryModel> CountryModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CountryModel>().HasKey(p => p.Country);
        }
    }
}
