namespace MusicAgent.Blazor.Configuration
{
    public class SemanticKernelOptions
    {
        public const string OpenAI_Model_Provider = "OpenAI";
        public const string Grok_Model_Provider = "Grok";
        public const string LMStudio_Model_Provider = "LMStudio";
        public const string Ollama_Model_Provider = "Ollama";

        public string ModelProvider { get; set; } = OpenAI_Model_Provider;
    }
}
