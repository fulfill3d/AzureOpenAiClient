namespace Client.Interfaces
{
    public interface IAzureOpenAiService
    {
        Task<IEnumerable<float[]>> GetEmbeddingsAsync(IEnumerable<string> texts);
    }
}