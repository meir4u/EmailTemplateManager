using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailTemplateManager.Infrastructure
{
    public static class InfrastructureServiceConfiguration
    {
        public static IServiceCollection ConfigurationInfrastructureService(this IServiceCollection service, IConfiguration configuration)
        {

            return service;
        }
    }
}
