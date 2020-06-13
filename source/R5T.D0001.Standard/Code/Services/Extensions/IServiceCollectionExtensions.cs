using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0001.Default;


namespace R5T.D0001.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="INowUtcProvider"/> service.
        /// </summary>
        public static IServiceCollection AddNowUtcProvider(this IServiceCollection services)
        {
            services.AddDefaultNowUtcProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="INowUtcProvider"/> service.
        /// </summary>
        public static IServiceCollection AddNowUtcProvider<TUtcNowProvider>(this IServiceCollection services)
            where TUtcNowProvider: INowUtcProvider
        {
            services.AddNowUtcProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="INowUtcProvider"/> service.
        /// </summary>
        public static IServiceAction<INowUtcProvider> AddNowUtcProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<INowUtcProvider>.New(() => services.AddNowUtcProvider());
            return serviceAction;
        }
    }
}
