using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class ProductMap: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("ac_products");
            builder.HasKey(x => x.IdProduct);
            builder.HasOne(x => x.Tenant);
        }
    }
}