# CLAUDE.md — Mem0 SDK

## Overview

Auto-generated C# SDK for [Mem0](https://mem0.ai/) — the AI memory layer for personalized agents.
Covers memories (add, search, list, update, delete), entities, agents, apps, users, organizations, projects, runs, webhooks, and stats.

## Build & Test

```bash
dotnet build Mem0.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Mem0 API key:

```csharp
var client = new Mem0Client(apiKey); // MEM0_API_KEY env var
```

Note: Mem0 uses `Token <key>` format internally (not `Bearer <key>`), but the SDK handles standard bearer auth. If auth fails, you may need a custom `PrepareRequest` partial to override the Authorization header format.

## Key Files

- `src/libs/Mem0/generate.sh` — Regeneration script (downloads spec, runs autosdk with `--security-scheme Http:Header:Bearer`)
- `src/libs/Mem0/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- OpenAPI spec: `https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json`
- Spec uses `apiKey` type auth with `Token ` prefix; `--security-scheme Http:Header:Bearer` overrides at generation time
- Some endpoints have empty response schemas — these return untyped responses
