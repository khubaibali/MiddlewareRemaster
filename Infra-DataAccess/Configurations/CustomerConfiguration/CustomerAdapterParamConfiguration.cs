using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra_DataAccess.Configurations.CustomerConfiguration;

internal class CustomerAdapterParamConfiguration : IEntityTypeConfiguration<CustomerAdapterParam>
{
    public void Configure(EntityTypeBuilder<CustomerAdapterParam> builder)
    {
        builder
            .HasKey(key => key.Id)
            .IsClustered(false);

    }
}
