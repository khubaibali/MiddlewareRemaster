using Domain;
using Infra_DataAccess.Configurations;
using Infra_DataAccess.Configurations.CustomerConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infra_DataAccess.DbContexts;

public partial class MiddlewareDbContext(DbContextOptions<MiddlewareDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdapterConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdapterMethodConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdapterParamConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerAdapterConfiguration).Assembly);
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContactConfiguration).Assembly);

    }
}
