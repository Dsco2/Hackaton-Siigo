using System.Collections.Generic;
using Business.Entities;

namespace Business.Interfaces
{
    public interface ITenantService
    {
        Tenant CreateTenant(Tenant tenant);
        List<Tenant> GetTenants();
    }
}
