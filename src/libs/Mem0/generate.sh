#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
# Note: Mem0 uses "Token " prefix (not "Bearer ") — may need PrepareRequest if auth fails.
autosdk generate openapi.json \
  --namespace Mem0 \
  --clientClassName Mem0Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
