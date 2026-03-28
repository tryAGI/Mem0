#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
# Note: Mem0 uses "Token " prefix (not "Bearer ") — may need PrepareRequest if auth fails.
autosdk generate openapi.json \
  --namespace Mem0 \
  --clientClassName Mem0Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
