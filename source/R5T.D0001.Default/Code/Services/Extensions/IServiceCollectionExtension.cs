using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0001.Default
{
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="NowUtcProvider"/> implementation of <see cref="INowUtcProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNowUtcProvider(this IServiceCollection services)
        {
            services.AddSingleton<INowUtcProvider, NowUtcProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="NowUtcProvider"/> implementation of <see cref="INowUtcProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<INowUtcProvider> AddNowUtcProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<INowUtcProvider>.New(() => services.AddNowUtcProvider());
            return serviceAction;
        }
    }
}
