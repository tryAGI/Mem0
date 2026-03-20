/*
order: 10
title: Search Memories
slug: search-memories

Search for memories using semantic search.
*/

namespace Mem0.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_SearchMemories()
    {
        using var client = GetAuthenticatedClient();

        //// Search for relevant memories using a natural language query.
        var results = await client.Memories.MemoriesSearchCreateAsync(
            query: "What are the user preferences?",
            userId: "test-user",
            topK: 5);

        Assert.IsNotNull(results);
    }
}
