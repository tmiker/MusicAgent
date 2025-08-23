namespace MusicAgent.Blazor.Configuration
{
    public class SemanticKernelSettings
    {
        public const string SectionName = "SemanticKernelSettings";

        // KEY OR PROVIDER PATH
        public string? OpenAI_ApiKey { get; set; }
        public string? Grok_ApiKey { get; set; }
        public string? LMStudio_Endpoint { get; set; }  // = "http://localhost:1234/v1";
        public string? Ollama_Endpoint { get; set; }  // = "http://localhost:11434/v1";

        // TEXT MODEL ID
        public string? OpenAI_TextModelId { get; set; }  // = "gpt-3.5-turbo";
        public string? Grok_TextModelId { get; set; }  // = "grok-2";
        public string? LMStudio_TextModelId { get; set; }  // = "phi-4";
        public string? Ollama_TextModelId { get; set; }  // = "llama3.2:latest";

        // IMAGE MODEL ID
        public string? OpenAI_ImageModelId { get; set; }  // = "dall-e-3";



    }
}

