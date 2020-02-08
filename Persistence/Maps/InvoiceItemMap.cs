using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class InvoiceItemMap : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("ac_invoice_items");
            builder.HasKey(x => x.IdInvoiceItem);
            builder.HasOne(x => x.Tenant);
            builder.HasOne(x => x.Product);
            builder.HasOne(x => x.Invoice);
        }
    }
}
