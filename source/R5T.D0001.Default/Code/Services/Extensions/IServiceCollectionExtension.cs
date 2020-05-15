using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0001.Default
{
    public static class IServiceCollectionExtension
    {
        /// <summary>
        /// Adds the <see cref="UtcNowProvider"/> implementation of <see cref="IUtcNowProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultUtcNowProvider(this IServiceCollection services)
        {
            services.AddSingleton<IUtcNowProvider, UtcNowProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UtcNowProvider"/> implementation of <see cref="IUtcNowProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultUtcNowProvider<TNowProvider>(this IServiceCollection services)
            where TNowProvider: IUtcNowProvider
        {
            services.AddDefaultUtcNowProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="UtcNowProvider"/> implementation of <see cref="IUtcNowProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IUtcNowProvider> AddDefaultUtcNowProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IUtcNowProvider>(() => services.AddDefaultUtcNowProvider());
            return serviceAction;
        }
    }
}
