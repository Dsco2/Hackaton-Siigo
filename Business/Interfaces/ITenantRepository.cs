using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ITenantRepository
    {
        Tenant CreateTenant(Tenant tenant);
        List<Tenant> GetTenants();
    }
}
