using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QualtricsServiceHttpClient;
namespace QualtricsHttpClient.DependencyInjection;

public static class DependencyInjection
{
   public static IServiceCollection AddQualtricsServiceDependency(this IServiceCollection services)
    {
        services.AddHttpClient<QualtricsService>();
        return services;
    } 
}
