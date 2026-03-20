# Add Memory

Add a memory from a conversation.

This example assumes `using Mem0;` is in scope and `apiKey` contains your Mem0 API key.

```csharp
using var client = new Mem0Client(apiKey);

// Add a memory from a user conversation.
var results = await client.Memories.MemoriesCreateAsync(
    messages: [
        new Dictionary<string, string?>
        {
            ["role"] = "user",
            ["content"] = "I prefer dark mode in all my applications.",
        },
    ],
    userId: "test-user");
```