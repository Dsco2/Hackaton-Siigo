using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seed
{
    public static class CustomersSeed
    {
        public static void Customer(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(GetCustomer());
        }

        private static Customer[] GetCustomer()
        {
            return new[]
            {
                new Customer {IdTenant = 3, IdCustomer =1, FirstName = "Daniel", LastName = "Cantor"},
                new Customer {IdTenant = 3, IdCustomer =2, FirstName = "Jorge", LastName = "Nuñez"},
                new Customer {IdTenant = 3, IdCustomer =3, FirstName = "Ricardo", LastName = "Gomez"},
                new Customer {IdTenant = 3, IdCustomer =4, FirstName = "Jessica", LastName = "Gonzalez"},
                new Customer {IdTenant = 3, IdCustomer =5, FirstName = "Felipe", LastName = "Rodriguez"},
                new Customer {IdTenant = 3, IdCustomer =6, FirstName = "Carolina", LastName = "Uribe"},
                new Customer {IdTenant = 3, IdCustomer =7, FirstName = "Diego", LastName = "Ortiz"},
                new Customer {IdTenant = 3, IdCustomer =8, FirstName = "Andres", LastName = "Robledo"},
                new Customer {IdTenant = 3, IdCustomer =9, FirstName = "Santiago", LastName = "Jimenez"},
                new Customer {IdTenant = 3, IdCustomer =10, FirstName = "Juan", LastName = "Santos"},
                new Customer {IdTenant = 3, IdCustomer =11, FirstName = "Sofia", LastName = "Robledo"},
                new Customer {IdTenant = 3, IdCustomer =12, FirstName = "Ana", LastName = "Cepeda"},
                new Customer {IdTenant = 3, IdCustomer =13, FirstName = "Maria", LastName = "Suarez"},
                new Customer {IdTenant = 3, IdCustomer =14, FirstName = "Carlos", LastName = "Rubiano"},
                new Customer {IdTenant = 3, IdCustomer =15, FirstName = "Enrique", LastName = "Saenz"},
                new Customer {IdTenant = 3, IdCustomer =16, FirstName = "Alberto", LastName = "Gomez"},
                new Customer {IdTenant = 3, IdCustomer =17, FirstName = "Laura", LastName = "Gonzalez"},
                new Customer {IdTenant = 3, IdCustomer =18, FirstName = "Sofia", LastName = "Rodriguez"},
                new Customer {IdTenant = 3, IdCustomer =19, FirstName = "Ana", LastName = "Uribe"},
                new Customer {IdTenant = 3, IdCustomer =20, FirstName = "Maria", LastName = "Ortiz"},
            };
        }
    }
}
