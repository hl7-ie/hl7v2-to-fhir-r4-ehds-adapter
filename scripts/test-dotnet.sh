#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")/../dotnet"

echo "Running .NET tests..."
dotnet test --configuration Release

echo ".NET tests complete."
