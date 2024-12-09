namespace Client.Options
{
    public class AzureOpenAiOptions
    {
        public string Endpoint { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string DeploymentName { get; set; } = string.Empty; // For embedding model deployment
    }
}