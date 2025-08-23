using MusicAgent.Blazor.SemanticKernel.ProviderDTOs;

namespace MusicAgent.Blazor.Abstractions
{
    public interface ILMStudioHttpProvider
    {
        Task<(bool IsSuccess, IEnumerable<LMStudioModelDTO>? LoadedModels, string? ErrorMessage)> GetLMStudioLoadedModelsAsync();
        
    }
}
