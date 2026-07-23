#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "$0")/.."

echo "Running tests..."
mvn test

echo "Tests complete."
