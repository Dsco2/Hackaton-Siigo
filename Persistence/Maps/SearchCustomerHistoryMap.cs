using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class SearchCustomerHistoryMap: IEntityTypeConfiguration<SearchCustomerHistory>
    {
        public void Configure(EntityTypeBuilder<SearchCustomerHistory> builder)
        {
            builder.ToTable("search_customer_history");
            builder.HasKey(x => x.IdSearchCustomerHistory);
            builder.HasOne(x => x.Customer);
        }
    }
}