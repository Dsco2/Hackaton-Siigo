using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class SearchProductHistoryMap: IEntityTypeConfiguration<SearchProductHistory>
    {
        public void Configure(EntityTypeBuilder<SearchProductHistory> builder)
        {
            builder.ToTable("search_history");
            builder.HasKey(x => x.IdSearchProductHistory);
            
            builder.HasOne(x => x.Product);
        }
    }
}