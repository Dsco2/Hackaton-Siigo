﻿using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Maps;
using Persistence.Seed;


namespace Persistence
{
    public class MainContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Hackathon");

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<InvoiceItem> InvoicesItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new TenantMap());
            modelBuilder.ApplyConfiguration(new InvoiceItemMap());
            modelBuilder.ApplyConfiguration(new InvoiceMap());
            modelBuilder.ApplyConfiguration(new SearchHistoryMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Tenant();
            modelBuilder.Product();
        }
    }
}