using MusicAgent.Blazor.SemanticKernel.ProviderDTOs;

namespace MusicAgent.Blazor.Abstractions
{
    public interface IOllamaHttpProvider
    {
        Task<(bool IsSuccess, IEnumerable<OllamaModelDTO>? LoadedModels, string? ErrorMessage)> GetOllamaLoadedModelsAsync();
    }
}
