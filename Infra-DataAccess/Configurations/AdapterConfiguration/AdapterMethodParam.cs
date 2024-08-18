
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

public class AdapterMethodParamConfiguration : IEntityTypeConfiguration<AdapterParam>
{
    public void Configure(EntityTypeBuilder<AdapterParam> builder)
    {
        builder
            .HasKey(c => c.Id)
            .IsClustered(false);

        builder
             .Property(c => c.KeyName)
             .HasMaxLength(128)
             .IsRequired();

        builder.Property(c => c.UiName)
            .HasMaxLength(128)
            .IsRequired();
    }
}
