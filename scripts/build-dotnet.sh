#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")/../dotnet"

echo "Building .NET HL7v2 to FHIR R4 EHDS Adapter..."
dotnet restore
dotnet build --no-restore --configuration Release
dotnet test --no-build --configuration Release

echo ".NET build complete."
