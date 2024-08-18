using Microsoft.Extensions.DependencyInjection;
using Domain.shared.ShortId;

namespace Infra_ShortUuidService;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraShortUuidService(this IServiceCollection services)
    {
        services.AddSingleton< ISquid, SquidService>();
        return services;
    }
}
