namespace MusicAgent.Blazor.Utility
{
    public class StaticData
    {
        // OPEN AI
        public const string OpenAI_TextModel_gpt3_5_Turbo = "gpt-3.5-turbo";
        public const string OpenAI_ImageModel_dall_e_3 = "dall-e-3";
        public const string OpenAI_EmbeddingModel_ada_002 = "text-embedding-ada-002";
        public static List<string> OpenAI_TextModels = new List<string>
        {
            OpenAI_TextModel_gpt3_5_Turbo
        };
        public static List<string> OpenAI_ImageModels = new List<string>
        {
            OpenAI_ImageModel_dall_e_3
        };

        // LM STUDIO
        public const string LMStudio_LocalModelId_phi4 = "phi-4";
        public const string LMStudio_LocalModelId_llama3_2 = "llama-3.2-3b-instruct";
        public static List<string> LMStudio_TextModels = new List<string>
        {
            LMStudio_LocalModelId_phi4, LMStudio_LocalModelId_llama3_2
        };
        public const string LMStudio_Endpoint = "http://localhost:1234/v1";

        // OLLAMA
        public const string Ollama_LocalModelId_phi3_Mini = "phi3:mini";
        public static List<string> Ollama_TextModels = new List<string>
        {
            Ollama_LocalModelId_phi3_Mini
        };
        public const string Ollama_Endpoint = "http://localhost:11434/v1";
        public const string Ollama_LoadedModelsPath = "/api/ps";

        // HTTP CLIENTS
        public const string LMStudioHttpClient_Name = "LMStudioHttpClient";
        public const string LMStudioHttpClient_BaseUrl = "http://localhost:1234";
        public const string LMStudioHttpClient_LoadedModelsPath = "/api/v0/models";

        public const string OllamaoHttpClient_Name = "OllamaHttpClient";
        public const string OllamaHttpClient_BaseUrl = "http://localhost:11434/v1";
        public const string OllamaHttpClient_LoadedModelsPath = "/api/ps";

    }
}
