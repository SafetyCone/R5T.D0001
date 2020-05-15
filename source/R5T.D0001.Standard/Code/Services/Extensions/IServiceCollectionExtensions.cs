using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0001.Default;


namespace R5T.D0001.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IUtcNowProvider"/> service.
        /// </summary>
        public static IServiceCollection AddUtcNowProvider(this IServiceCollection services)
        {
            services.AddDefaultUtcNowProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IUtcNowProvider"/> service.
        /// </summary>
        public static IServiceCollection AddUtcNowProvider<TUtcNowProvider>(this IServiceCollection services)
            where TUtcNowProvider: IUtcNowProvider
        {
            services.AddUtcNowProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IUtcNowProvider"/> service.
        /// </summary>
        public static ServiceAction<IUtcNowProvider> AddUtcNowProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IUtcNowProvider>.New(() => services.AddUtcNowProvider());
            return serviceAction;
        }
    }
}
