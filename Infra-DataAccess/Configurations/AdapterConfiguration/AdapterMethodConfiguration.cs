using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

public class AdapterMethodConfiguration : IEntityTypeConfiguration<AdapterMethod>
{
    public void Configure(EntityTypeBuilder<AdapterMethod> builder)
    {
        builder
            .HasKey(m=> m.Id)
            .IsClustered(false);

        builder
            .Property(x => x.Id)
            .HasConversion(v => v.Id,
            v => new AdapterMethodId(v));

        builder
            .Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);

        
    }
}
