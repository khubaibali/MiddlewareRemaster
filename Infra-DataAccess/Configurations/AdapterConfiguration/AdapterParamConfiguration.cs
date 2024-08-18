using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infra_DataAccess.Configurations;

public class AdapterParamConfiguration : IEntityTypeConfiguration<AdapterParam>
{
    public void Configure(EntityTypeBuilder<AdapterParam> builder)
    {
        builder.HasKey(x => x.Id)
            .IsClustered(false);

        builder.Property(x => x.KeyName)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(x => x.UiName)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(x => x.IsRequired);

    }
}
