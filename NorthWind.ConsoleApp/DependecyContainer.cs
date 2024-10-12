using Microsoft.Extensions.DependencyInjection;
using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Extensions.DependecyInjection.DependecyContainer;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddNorthWindServices(this IServiceCollection services)
    {
        services.AddDebugWriter();
        return services;
    }

   
}
