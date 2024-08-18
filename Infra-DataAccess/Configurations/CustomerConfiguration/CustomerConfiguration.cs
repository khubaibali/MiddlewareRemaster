using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_DataAccess.Configurations.CustomerConfiguration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .HasKey(x => x.Id)
            .IsClustered(false);

        builder
            .Property(x => x.CustomerName)
            .IsRequired()
            .HasMaxLength(100);

        builder
            .HasMany(x => x.CustomerAdapters)
            .WithOne()
            .HasForeignKey("CustomerId")
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasMany(prop => prop.Contacts)
            .WithOne(prop => prop.Customer)
            .HasForeignKey("CustomerId")
            .OnDelete(DeleteBehavior.NoAction);

    }
}
