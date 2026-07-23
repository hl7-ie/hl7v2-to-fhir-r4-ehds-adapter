#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")/.."

echo "Building HL7v2 to FHIR R4 EHDS Adapter..."
mvn clean verify

echo "Build complete."
