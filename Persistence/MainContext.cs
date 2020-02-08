using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;


namespace Persistence
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hackathon");

        public DbSet<Customer> Data { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}