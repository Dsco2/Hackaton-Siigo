using System.Collections.Generic;
using Business.Entities;
using Business.Interfaces;

namespace Business.Services
{
    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public Tenant CreateTenant(Tenant tenant)
        {
            return _tenantRepository.CreateTenant(tenant);
        }

        public List<Tenant> GetTenants()
        {
            return _tenantRepository.GetTenants();
        }
    }
}
