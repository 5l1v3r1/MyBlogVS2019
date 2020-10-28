using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    public class EtiketConfiguration : IEntityTypeConfiguration<Etiket>
    {
        public void Configure(EntityTypeBuilder<Etiket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.BlogId).IsRequired();
        }
    }
}
