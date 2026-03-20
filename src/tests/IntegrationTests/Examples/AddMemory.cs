/*
order: 20
title: Add Memory
slug: add-memory

Add a memory from a conversation.
*/

namespace Mem0.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_AddMemory()
    {
        using var client = GetAuthenticatedClient();

        //// Add a memory from a user conversation.
        var results = await client.Memories.MemoriesCreateAsync(
            messages: [
                new Dictionary<string, string?>
                {
                    ["role"] = "user",
                    ["content"] = "I prefer dark mode in all my applications.",
                },
            ],
            userId: "test-user");

        Assert.IsNotNull(results);
    }
}
