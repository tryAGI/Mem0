# Authentication

The Mem0 SDK uses Bearer token authentication. You can obtain an API key from your [Mem0 dashboard](https://app.mem0.ai/).

## Basic Usage

```csharp
using Mem0;

var client = new Mem0Client(apiKey: Environment.GetEnvironmentVariable("MEM0_API_KEY")!);
```

!!! note
    Mem0 internally uses `Token <key>` format instead of standard `Bearer <key>`. If you encounter authentication issues, a custom `PrepareRequest` partial method may be needed to adjust the Authorization header format.

## Environment Variable

| Variable | Description |
|----------|-------------|
| `MEM0_API_KEY` | Your Mem0 API key |
