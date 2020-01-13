using Microsoft.Extensions.DependencyInjection;
using StrategyPatternSample.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternSample.API.Config
{
    public static class DependencyConfig
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {

            //Injection de toute les implémentations pour le strategy pattern
            #region strategy
            services.AddTransient<IConfirmationService, ConfirmationEmailService>();
            services.AddTransient<IConfirmationService, ConfirmationSMSService>();
            #endregion


            return services;
        }
    }
}
