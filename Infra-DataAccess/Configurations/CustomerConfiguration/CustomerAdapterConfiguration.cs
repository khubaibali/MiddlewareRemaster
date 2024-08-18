using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

public class CustomerAdapterConfiguration : IEntityTypeConfiguration<CustomerAdapter>
{
    public void Configure(EntityTypeBuilder<CustomerAdapter> builder)
    {
        builder.HasKey(x => x.Id)
            .IsClustered(false)
            .HasName("ID");

        builder.Property(x => x.CustomerAdapterName)
            .IsRequired(true)
            .HasMaxLength(50);


        builder.HasOne<Customer>()
            .WithMany(x => x.CustomerAdapters)
            .HasForeignKey(x => x.Id);
    }
}
