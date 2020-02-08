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
                new Product {Name = "Billetera negra", Description = "Billetera negra de cuero", IdTenant = 3, ListPrice =100000, IdProduct = 1},
                new Product {Name = "Billeteras artesanales", Description = "Billeteras artesanales de cuero", IdTenant = 3, ListPrice =75000, IdProduct = 2},
                new Product {Name = "Biiletera gris", Description = "Biiletera gris de cuero", IdTenant = 3, ListPrice =350000, IdProduct = 3},
                new Product {Name = "Billetera importada", Description = "Billetera importada de cuero", IdTenant = 3, ListPrice =350001, IdProduct = 4},
                new Product {Name = "Sombreros para hombre", Description = "Sombreros para hombre de cuero", IdTenant = 3, ListPrice =350002, IdProduct = 5},
                new Product {Name = "Cinturón para hombre", Description = "Cinturón para hombre de cuero", IdTenant = 3, ListPrice =350003, IdProduct = 6},
                new Product {Name = "Cinturón para mujer", Description = "Cinturón para mujer de cuero", IdTenant = 3, ListPrice =350004, IdProduct = 7},
                new Product {Name = "Cinturón importado", Description = "Cinturón importado de cuero", IdTenant = 3, ListPrice =350005, IdProduct = 8},
                new Product {Name = "Billetera para mujer", Description = "Billetera para mujer de cuero", IdTenant = 3, ListPrice =350006, IdProduct = 9},
                new Product {Name = "Cinturón con diseños", Description = "Cinturón con diseños de cuero", IdTenant = 3, ListPrice =350007, IdProduct = 10},
                new Product {Name = "Cinturón artesanal", Description = "Cinturón artesanal de cuero", IdTenant = 3, ListPrice =350008, IdProduct = 11},
                new Product {Name = "Billetera para Hombre", Description = "Billetera para Hombre de cuero", IdTenant = 3, ListPrice =350009, IdProduct = 12},
                new Product {Name = "Sombreros para mujer", Description = "Sombreros para mujer de cuero", IdTenant = 3, ListPrice =350003, IdProduct = 13},
                new Product {Name = "Chaqueta tipo motociclista", Description = "Chaqueta tipo motociclista de cuero", IdTenant = 3, ListPrice =350004, IdProduct = 14},
                new Product {Name = "Chaqueta importada", Description = "Chaqueta importada de cuero", IdTenant = 3, ListPrice =350005, IdProduct = 15},
                new Product {Name = "Chaqueta artesanal", Description = "Chaqueta artesanal de cuero", IdTenant = 3, ListPrice =350006, IdProduct = 16},
                new Product {Name = "Chaqueta para mujer", Description = "Chaqueta para mujer de cuero", IdTenant = 3, ListPrice =350007, IdProduct = 17},
                new Product {Name = "Chaqueta para hombre", Description = "Chaqueta para hombre de cuero", IdTenant = 3, ListPrice =350007, IdProduct = 18},
                new Product {Name = "Sombrero importado", Description = "Sombrero importado de cuero", IdTenant = 3, ListPrice =200000, IdProduct = 19},
                new Product {Name = "Papa criolla", Description = "Papa criolla marca Jumbo", IdTenant = 2, ListPrice =5646, IdProduct = 20},
                new Product {Name = "Papa sabadera", Description = "Papa sabadera marca Jumbo", IdTenant = 2, ListPrice =45645, IdProduct = 21},
                new Product {Name = "Papa importada", Description = "Papa importada marca Jumbo", IdTenant = 2, ListPrice =3546, IdProduct = 22},
                new Product {Name = "Papas fritas", Description = "Papas fritas marca Jumbo", IdTenant = 2, ListPrice =64554, IdProduct = 23},
                new Product {Name = "Papas ", Description = "Papas  marca Jumbo", IdTenant = 2, ListPrice =15616, IdProduct = 24},
                new Product {Name = "Tomates", Description = "Tomates marca Jumbo", IdTenant = 2, ListPrice =65464, IdProduct = 25},
                new Product {Name = "Piñas", Description = "Piñas marca Jumbo", IdTenant = 2, ListPrice =4468, IdProduct = 26},
                new Product {Name = "Cebollas", Description = "Cebollas marca Jumbo", IdTenant = 2, ListPrice =114, IdProduct = 27},
                new Product {Name = "Leche", Description = "Leche marca Exito", IdTenant = 1, ListPrice =56454, IdProduct = 28},
                new Product {Name = "Leche entera", Description = "Leche entera marca Exito", IdTenant = 1, ListPrice =100000, IdProduct = 29},
                new Product {Name = "Leche deslactosada", Description = "Leche deslactosada marca Exito", IdTenant = 1, ListPrice =654654, IdProduct = 30},
                new Product {Name = "Leche descremada", Description = "Leche descremada marca Exito", IdTenant = 1, ListPrice =45655, IdProduct = 31},
                new Product {Name = "Leche de almendras", Description = "Leche de almendras marca Exito", IdTenant = 1, ListPrice =5454, IdProduct = 32},
                new Product {Name = "Leche de soja", Description = "Leche de soja marca Exito", IdTenant = 1, ListPrice =5456, IdProduct = 33},
                new Product {Name = "Arroz integral", Description = "Arroz integral marca Exito", IdTenant = 1, ListPrice =8785, IdProduct = 34},
                new Product {Name = "Ropa informal", Description = "Ropa informal marca Exito", IdTenant = 1, ListPrice =2156, IdProduct = 35},
                new Product {Name = "Arroz", Description = "Arroz marca Exito", IdTenant = 1, ListPrice =65464, IdProduct = 36},
                new Product {Name = "Frijol", Description = "Frijol marca Exito", IdTenant = 1, ListPrice =6554654, IdProduct = 37},
                new Product {Name = "Ropa formal", Description = "Ropa formal marca Exito", IdTenant = 1, ListPrice =6546, IdProduct = 38},
                new Product {Name = "Carnes congeladas", Description = "Carnes congeladas marca Exito", IdTenant = 1, ListPrice =65465, IdProduct = 39}
            };
        }
    }
}
