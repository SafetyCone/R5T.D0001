using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using DefaultIServiceCollectionExtensions = R5T.D0001.Default.IServiceCollectionExtension;


namespace R5T.D0001.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="INowUtcProvider"/> service.
        /// </summary>
        public static IServiceCollection AddNowUtcProvider(this IServiceCollection services)
        {
            var nowUtcProviderAction = services.AddNowUtcProviderAction();

            services.Run(nowUtcProviderAction);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="INowUtcProvider"/> service.
        /// </summary>
        public static IServiceAction<INowUtcProvider> AddNowUtcProviderAction(this IServiceCollection services)
        {
            var serviceAction = DefaultIServiceCollectionExtensions.AddNowUtcProviderAction(services);
            return serviceAction;
        }
    }
}
