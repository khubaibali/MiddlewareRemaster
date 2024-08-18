


using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

internal sealed class AdapterConfiguration : IEntityTypeConfiguration<Adapter>
{
    public void Configure(EntityTypeBuilder<Adapter> builder)
    {
        builder
            .HasKey("Id")
            .IsClustered(true);

        builder
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .Property(prop => prop.Type)
            .IsRequired()
            .HasConversion(
                prop => nameof(prop),
                  val => Enum.Parse<AdapterType>(val,true));

        builder
            .HasIndex(c => new { c.Name, c.Code })
            .IsUnique(true);

        builder
            .HasMany(a => a.Methods)
            .WithOne()
            .HasForeignKey("AdapterId")
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasMany(a => a.Params)
            .WithOne()
            .HasForeignKey("AdapterId")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
