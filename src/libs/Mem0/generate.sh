#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://raw.githubusercontent.com/mem0ai/mem0/main/docs/openapi.json -o openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
# Note: Mem0 uses "Token " prefix (not "Bearer ") — may need PrepareRequest if auth fails.
autosdk generate openapi.json \
  --namespace Mem0 \
  --clientClassName Mem0Client \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
