using System.Security.Cryptography.X509Certificates;
using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class InvoiceMap: IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("ac_invoices");
            builder.HasKey(x => x.IdInvoice);

        }
    }
}