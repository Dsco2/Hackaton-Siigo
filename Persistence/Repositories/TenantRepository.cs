using System.Collections.Generic;
using System.Linq;
using Business.Entities;
using Business.Interfaces;

namespace Persistence.Repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly MainContext _context;

        public TenantRepository(MainContext context)
        {
            _context = context;
        }

        public Tenant CreateTenant(Tenant tenant)
        {
            _context.Tenants.Add(tenant);
            _context.SaveChanges();
            return tenant;
        }

        public List<Tenant> GetTenants()
        {
            return _context.Tenants.ToList();
        }
    }
}
