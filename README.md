# Mem0

[![Nuget package](https://img.shields.io/nuget/vpre/Mem0)](https://www.nuget.org/packages/Mem0/)
[![dotnet](https://github.com/tryAGI/Mem0/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Mem0/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Mem0)](https://github.com/tryAGI/Mem0/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Mem0 OpenAPI specification](https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Mem0;

using var client = new Mem0Client(apiKey);
```

<!-- EXAMPLES:START -->
### Search Memories
Search for memories using semantic search.

```csharp
using var client = new Mem0Client(apiKey);

// Search for relevant memories using a natural language query.
var results = await client.Memories.MemoriesSearchCreateAsync(
    query: "What are the user preferences?",
    userId: "test-user",
    topK: 5);
```

### Add Memory
Add a memory from a conversation.

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
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Mem0/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Mem0/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
