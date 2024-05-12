using Microsoft.Extensions.DependencyInjection;
namespace Connector.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection ConnectorDependencies(this IServiceCollection services)
    {
        return services.AddHttpClient();
    }
}
