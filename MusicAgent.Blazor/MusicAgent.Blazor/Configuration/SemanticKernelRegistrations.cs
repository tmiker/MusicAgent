using Microsoft.AspNetCore.Components;
using Microsoft.SemanticKernel;

namespace MusicAgent.Blazor.Configuration
{
    public static class SemanticKernelRegistrations
    {
        public static IServiceCollection RegisterSemanticKernelServices(this IServiceCollection services, IConfiguration config, Action<SemanticKernelOptions> optionsModifier)
        {
            var kernelOptions = new SemanticKernelOptions();
            optionsModifier(kernelOptions);

            if (kernelOptions.ModelProvider == SemanticKernelOptions.OpenAI_Model_Provider)
            {
                services.AddKernel()
                    .AddOpenAIChatCompletion(
                        modelId: config.GetSection("SemanticKernelSettings").GetValue<string>("OpenAI_TextModelId")!,
                        apiKey: config.GetSection("SemanticKernelSettings").GetValue<string>("OpenAI_ApiKey")!)
                    .AddOpenAITextToImage(
                        apiKey: config.GetSection("SemanticKernelSettings").GetValue<string>("OpenAI_ApiKey")!,
                        modelId: config.GetSection("SemanticKernelSettings").GetValue<string>("OpenAI_ImageModelId")!);
            }
            else if (kernelOptions.ModelProvider == SemanticKernelOptions.Grok_Model_Provider)
            {
                services.AddKernel()
                    .AddOpenAIChatCompletion(
                        modelId: config.GetSection("SemanticKernelSettings").GetValue<string>("Grok_TextModelId")!,
                        apiKey: config.GetSection("SemanticKernelSettings").GetValue<string>("Grok_ApiKey")!);
            }
            else if (kernelOptions.ModelProvider == SemanticKernelOptions.LMStudio_Model_Provider)
            {
                services.AddKernel()
                    .AddOpenAIChatCompletion(
                        modelId: config.GetSection("SemanticKernelSettings").GetValue<string>("LMStudio_TextModelId")!,
                        apiKey: null,
                        endpoint: new Uri(config.GetSection("SemanticKernelSettings").GetValue<string>("LMStudio_Endpoint")!));

            }
            else if (kernelOptions.ModelProvider == SemanticKernelOptions.Ollama_Model_Provider)
            {
                services.AddKernel()
                    .AddOpenAIChatCompletion(
                        modelId: config.GetSection("SemanticKernelSettings").GetValue<string>("Ollama_TextModelId")!,
                        apiKey: null,
                        endpoint: new Uri(config.GetSection("SemanticKernelSettings").GetValue<string>("Ollama_Endpoint")!));
            }
            else throw new InvalidDataException("Invalid ModelProvider configured");

            // Register the cascading value source to inject in the component for access to underlying source's NotifyChangedAsync() method
            services.AddScoped(sp =>
                {
                    var kernelInfo = new SemanticKernelInfo() { ModelProvider = kernelOptions.ModelProvider };
                    return new CascadingValueSource<SemanticKernelInfo>(name: "SemanticKernelInfo", kernelInfo, isFixed: false);
                });
            // Register the cascading value that will be the cascading parameter property on component pages by deriving from the source
            services.AddCascadingValue(sp => sp.GetRequiredService<CascadingValueSource<SemanticKernelInfo>>());

            return services;
        }
    }
}
