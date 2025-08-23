using MusicAgent.Blazor.Abstractions;
using MusicAgent.Blazor.SemanticKernel.ProviderServices;
using MusicAgent.Blazor.Utility;

namespace MusicAgent.Blazor.Configuration
{
    public static class LocalModelProviderRegistrations
    {
        public static IServiceCollection RegisterLocalModelProviderServices(this IServiceCollection services)
        {
            // HTTP CLIENTS
            services.AddHttpClient(name: StaticData.LMStudioHttpClient_Name, cfg =>
            {
                cfg.DefaultRequestHeaders.Clear();
                cfg.BaseAddress = new Uri(StaticData.LMStudioHttpClient_BaseUrl);
            });
            services.AddSingleton<ILMStudioHttpProvider, LMStudioHttpProvider>();

            services.AddHttpClient(name: StaticData.OllamaoHttpClient_Name, cfg =>
            {
                cfg.DefaultRequestHeaders.Clear();
                cfg.BaseAddress = new Uri(StaticData.OllamaHttpClient_BaseUrl);
            });
            services.AddSingleton<IOllamaHttpProvider, OllamaHttpProvider>();

            return services;
        }
    }
}
