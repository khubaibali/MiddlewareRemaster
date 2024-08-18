using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

public class CustomerAdapterConfiguration : IEntityTypeConfiguration<CustomerAdapter>
{
    public void Configure(EntityTypeBuilder<CustomerAdapter> builder)
    {
        builder
            .HasKey(x => x.Id)
            .IsClustered(false);

        builder
            .Property(x => x.CustomerAdapterName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.HasMany(prop => prop.CustomerAdapterParams)
            .WithOne()
            .HasForeignKey("CustomerAdapterId")
            .OnDelete(DeleteBehavior.NoAction);

    }
}
