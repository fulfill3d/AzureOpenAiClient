using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
    public static class DepInj
    {
        public static void RegisterAzureOpenAiClient(
            this IServiceCollection service,
            Action<AzureOpenAiOptions> configureOptions)
        {
            service.ConfigureServiceOptions<AzureOpenAiOptions>((_, opt) => configureOptions(opt));
            service.AddTransient<IAzureOpenAiService, AzureOpenAiService>();
        }

        private static void ConfigureServiceOptions<TOptions>(
            this IServiceCollection services,
            Action<IServiceProvider, TOptions> configure)
            where TOptions : class
        {
            services
                .AddOptions<TOptions>()
                .Configure<IServiceProvider>((options, resolver) => configure(resolver, options));
        }
    }
}