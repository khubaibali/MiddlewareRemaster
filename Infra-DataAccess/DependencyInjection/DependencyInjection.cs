
using Domain.Interface.Repository;
using Domain.shared.ShortId;
using Infra_DataAccess.DbContexts;
using Infra_DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_DataAccess.DependencyInjection;

public static class DependencyInjection
{
    // Add your own dependency injection configuration here
    public static IServiceCollection AddInfraDataAccess(this IServiceCollection services)
    {
        services.AddDbContext<MiddlewareDbContext>(options =>
        options.UseSqlServer("Server=localhost;Database=practice;Trusted_Connection=True;TrustServerCertificate=True")
        );

        #region repositories
        services.AddScoped<ICustomerRepo, CustomerRepository>();
        #endregion

        return services;
    }
}
