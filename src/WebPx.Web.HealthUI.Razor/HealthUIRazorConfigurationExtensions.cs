// ReSharper disable once CheckNamespace
using Microsoft.Extensions.Configuration;
using WebPx.Web.HealthUI.Razor.Settings;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Class with extensions to configure the Razor UI for the hosted services
    /// </summary>
    public static class HealthUIRazorConfigurationExtensions
    {
        /// <summary>
        /// Method to add the hosted services UI configuration to the service collection
        /// </summary>
        /// <param name="services">The service collection</param>
        /// <param name="action">The action to configure the settings</param>
        /// <param name="configuration">The configuration provider to bind to</param>
        /// <returns>Returns the service collection</returns>
        public static IServiceCollection AddHealthUI(this IServiceCollection services, Action<HealthUISettings>? action = default, IConfiguration? configuration = default)
        {
            var builder = services
                .AddOptions<HealthUISettings>();
            if (action != null)
                builder.Configure(action);
            if (configuration != null)
                builder.Bind(configuration.GetSection("WebPx:Health:UI"));
            return services;
        }
    }
}