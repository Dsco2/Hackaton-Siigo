using Autofac;
using Business.Interfaces;
using Business.Services;


namespace IoC
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerService>().As<ICustomerService>();
        }
        
    }
}