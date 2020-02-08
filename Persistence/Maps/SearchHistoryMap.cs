using Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Maps
{
    public class SearchHistoryMap: IEntityTypeConfiguration<SearchHistory>
    {
        public void Configure(EntityTypeBuilder<SearchHistory> builder)
        {
            builder.ToTable("search_history");
            builder.HasKey(x => x.IdSearchHistory);
        }
    }
}