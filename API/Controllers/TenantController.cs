using Business.Entities;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        //Tenant/createTenant
        [HttpPost("createTenant")]
        public IActionResult CreateTenant(Tenant tenant)
        {
            if (tenant == null)
            {
                return BadRequest();
            }

            var tenantResponse = _tenantService.CreateTenant(tenant);

            return tenantResponse == null
                ? StatusCode(500)
                : (IActionResult)Ok(tenantResponse);
        }

        //tenant/getTenants
        [HttpGet("getTenants")]
        public IActionResult GetTenants()
        {
            var tenants = _tenantService.GetTenants();

            return tenants == null
                ? StatusCode(500)
                : (IActionResult)Ok(tenants);
        }
    }
}
