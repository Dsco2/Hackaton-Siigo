using Autofac;
using Business.Interfaces;
using Business.Services;
using Persistence.Repositories;


namespace IoC
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<TenantService>().As<ITenantService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<TenantRepository>().As<ITenantRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
        }
        
    }
}