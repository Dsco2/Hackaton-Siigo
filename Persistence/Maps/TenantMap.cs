using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class TenantMap: IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("ac_tenant");
            builder.HasKey(x => x.IdTenant);




            //builder.HasOne(x => x.Invoice)
            //    .WithMany(dp => dp.Tenant);
            //    //.HasForeignKey(x => x.IdTenant);

            //builder.HasOne(x => x.InvoiceItem)
            //    .WithMany(dp => dp.Tenant);
            //    //.HasForeignKey(x => x.IdTenant);

            //builder.HasOne(x => x.Customer)
            //    .WithMany(dp => dp.Tenant);
            //    //.HasForeignKey(x => x.IdTenant);

            //builder.HasOne(x => x.Product)
            //    .WithMany(dp => dp.Tenant);
            //    //.HasForeignKey(x => x.IdTenant);
        }
    }
}
