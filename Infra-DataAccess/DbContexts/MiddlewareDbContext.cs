using Domain;
using Infra_DataAccess.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infra_DataAccess.DbContexts;

public class MiddlewareDbContext : DbContext
{
    public DbSet<Contact> Contacts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ContactConfiguration).Assembly);
    }
}
