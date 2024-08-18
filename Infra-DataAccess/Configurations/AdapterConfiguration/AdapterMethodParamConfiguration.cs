
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra_DataAccess.Configurations;

public class AdapterMethodParamConfiguration : IEntityTypeConfiguration<AdapterMethodParam>
{
    public void Configure(EntityTypeBuilder<AdapterMethodParam> builder)
    {
        builder
            .HasKey(c => c.Id)
            .IsClustered(false);

        
    }
}
