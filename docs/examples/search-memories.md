# Search Memories

Search for memories using semantic search.

This example assumes `using Mem0;` is in scope and `apiKey` contains your Mem0 API key.

```csharp
using var client = new Mem0Client(apiKey);

// Search for relevant memories using a natural language query.
var results = await client.Memories.MemoriesSearchCreateAsync(
    query: "What are the user preferences?",
    userId: "test-user",
    topK: 5);
```