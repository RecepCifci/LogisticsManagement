using Microsoft.Extensions.DependencyInjection;
using System;


namespace LogisticsManagement.Core.Util.IOC
{
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProviders { get; set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            
            ServiceProviders = services.BuildServiceProvider();
            return services;
        }
    }
}
