
using Domain.shared.ShortId;
using Infra_DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra_DataAccess.DependencyInjection;

public static class DependencyInjection
{
    // Add your own dependency injection configuration here
    public static IServiceCollection AddInfraDataAccess(this IServiceCollection services)
    {
        services.AddDbContext<MiddlewareDbContext>(options =>
        options.UseSqlServer("Server=localhost;Database=Q2sTest;Trusted_Connection=True;TrustServerCertificate=True")
        );
            
        return services;
    }
}
