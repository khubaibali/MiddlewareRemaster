using Domain;
using Domain.Gateways;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infra_DataAccess.DbContexts;

public partial class MiddlewareDbContext(DbContextOptions<MiddlewareDbContext> options) : DbContext(options)
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<QualtricsGateway> Qualtrics { get; set; } 
    public DbSet<Contact> Contacts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Entity<Gateway>()
            .UseTpcMappingStrategy();
        modelBuilder.Entity<QualtricsGateway>()
            .ToTable("QualtricsGateway");
    }
}
