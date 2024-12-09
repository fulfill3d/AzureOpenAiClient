using Azure;
using Azure.AI.OpenAI;
using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.Options;

namespace Client
{
    public class AzureOpenAiService : IAzureOpenAiService
    {
        private readonly AzureOpenAiOptions _options;
        private readonly OpenAIClient _client;

        public AzureOpenAiService(IOptions<AzureOpenAiOptions> options)
        {
            _options = options.Value;
            _client = new OpenAIClient(
                new Uri(_options.Endpoint),
                new AzureKeyCredential(_options.ApiKey)
            );
        }

        public async Task<IEnumerable<float[]>> GetEmbeddingsAsync(IEnumerable<string> texts)
        {
            var tasks = texts.Select(async text =>
            {
                var embeddingOptions = new EmbeddingsOptions(text);
                var response = await _client.GetEmbeddingsAsync(_options.DeploymentName, embeddingOptions);
                return response.Value.Data[0].Embedding.ToArray();
            });

            return await Task.WhenAll(tasks);
        }
    }
}