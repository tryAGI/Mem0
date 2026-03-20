namespace Mem0.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static Mem0Client GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("MEM0_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("MEM0_API_KEY environment variable is not found.");

        var client = new Mem0Client(apiKey);
        
        return client;
    }
}
