
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

internal sealed class AdapterConfiguration : IEntityTypeConfiguration<Adapter>
{
    public void Configure(EntityTypeBuilder<Adapter> builder)
    {
        builder
            .HasKey(c => c.Id)
            .IsClustered(false);

        builder
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasIndex(c => new { c.Name, c.Code })
            .IsUnique(true);
        
        builder
            .HasMany(a => a.Methods)
            .WithOne(m => m.Adapter)
            .HasForeignKey(m => m.Adapter)
            .OnDelete(DeleteBehavior.Cascade); 
        
        builder
            .HasMany(a => a.Params)
            .WithOne(a => a.Adapter)
            .HasForeignKey(a => a.Adapter)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
