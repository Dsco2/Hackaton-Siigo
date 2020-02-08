using Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seed
{
    public static class TenantsSeed
    {
        public static void Tenant(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>().HasData(GetTenant());
        }

        private static Tenant[] GetTenant()
        {
            return new[]
            {
                new Tenant {IdTenant = 1, Name = "Exito", Theme = "warning"},
                new Tenant {IdTenant = 2, Name = "Jumbo", Theme = "primary"},
                new Tenant {IdTenant = 3, Name = "Cueros SAS", Theme = "info"}
            };
        }
    }
}
