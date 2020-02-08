using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seed
{
    public static class ProductsSeed
    {
        public static void Product(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProduct());
        }

        private static Product[] GetProduct()
        {
            return new[]
            {
                new Product {Name = "wallet", Description = "Lether wallet", IdTenant = 3, ListPrice =100000, IdProduct = 1},
                new Product {Name = "Shoes", Description = "Lether Shoes", IdTenant = 3, ListPrice =75000, IdProduct = 2},
                new Product {Name = "Jacket", Description = "Lether Jacket", IdTenant = 3, ListPrice =350000, IdProduct = 3},
                new Product {Name = "Hat", Description = "Lether Hat", IdTenant = 3, ListPrice =200000, IdProduct = 4},
                new Product {Name = "Potatoes", Description = "Fresh Potatoes", IdTenant = 2, ListPrice =15616, IdProduct = 5},
                new Product {Name = "Tomatoes", Description = "Fresh Tomatoes", IdTenant = 2, ListPrice =65464, IdProduct = 6},
                new Product {Name = "Pineaples", Description = "Fresh Pineaples", IdTenant = 2, ListPrice =4468, IdProduct = 7},
                new Product {Name = "Onions", Description = "Fresh Onions", IdTenant = 2, ListPrice =114, IdProduct = 8},
                new Product {Name = "Rice", Description = "Rice", IdTenant = 1, ListPrice =65464, IdProduct = 9},
                new Product {Name = "Beens", Description = "Beens", IdTenant = 1, ListPrice =6554654, IdProduct = 10},
                new Product {Name = "Clothes", Description = "Clothes", IdTenant = 1, ListPrice =6546, IdProduct = 11},
                new Product {Name = "Meat", Description = "Meat", IdTenant = 1, ListPrice =65465, IdProduct = 12}
            };
        }
    }
}
