# HL7v2 to FHIR R4 EHDS Adapter

[![CI](https://github.com/hl7-ie/hl7v2-to-fhir-r4-ehds-adapter/actions/workflows/ci.yml/badge.svg)](https://github.com/hl7-ie/hl7v2-to-fhir-r4-ehds-adapter/actions/workflows/ci.yml)
[![License](https://img.shields.io/badge/License-Apache%202.0%20%7C%20MIT-blue.svg)](./LICENSE)

A reusable, enterprise-ready adapter for converting HL7v2 messages used by the **European Health Data Space (EHDS)** specifications into **FHIR R4** resources and bundles.

## Goals

- Provide a standards-based bridge between legacy HL7v2 feeds and FHIR R4 endpoints.
- Ship declarative, versioned, profile-aware mappings aligned with EHDS requirements.
- Expose both a REST API and a command-line interface for flexible deployment.
- Enforce code quality, security scanning, and automated FHIR validation in CI.

## Technology Stack

The adapter is implemented in two runtimes:

### Java
- **Runtime**: Java 17, Spring Boot 3.2
- **HL7v2 Parsing**: HAPI HL7v2
- **FHIR Model & Validation**: HAPI FHIR R4
- **Build**: Apache Maven
- **Quality**: Checkstyle, SpotBugs, OWASP Dependency-Check

### .NET
- **Runtime**: .NET 8
- **HL7v2 Parsing**: nHapi
- **FHIR Model & Validation**: Firely .NET SDK (Hl7.Fhir.R4)
- **Build**: `dotnet` CLI / Visual Studio
- **Testing**: xUnit, FluentAssertions, Microsoft.AspNetCore.Mvc.Testing

## Supported Messages (Roadmap)

| HL7v2 Message | FHIR R4 Targets | Status |
|---------------|-----------------|--------|
| `ADT^A01`     | Patient, Encounter | Planned |
| `ADT^A08`     | Patient, Encounter | Planned |
| `ADT^A31`     | Patient, Encounter | Planned |
| `ORU^R01`     | Observation, DiagnosticReport | Planned |
| `MDM^T02`     | DocumentReference | Planned |
| `PPR^...`     | CarePlan, MedicationRequest | Planned |
| `VXU^V04`     | Immunization | Planned |

## Build

### Java

```bash
./scripts/build.sh
```

Or directly with Maven:

```bash
mvn clean verify
```

### .NET

```bash
./scripts/build-dotnet.sh
```

Or directly:

```bash
cd dotnet
dotnet build -c Release
dotnet test -c Release
```

## Test

### Java

```bash
./scripts/test.sh
```

### .NET

```bash
./scripts/test-dotnet.sh
```

## Usage

### Java

After building:

```bash
java -jar target/hl7v2-to-fhir-r4-ehds-adapter-*.jar
```

### .NET

After building:

```bash
cd dotnet/src/Hl7v2ToFhirEhdsAdapter.WebApi
dotnet run
```

## Project Structure

```
├── docs/                 # Architecture, deployment, and mapping documentation
├── config/               # Quality and security tool configurations
├── scripts/              # Build and test helper scripts
├── src/                  # Java adapter source code and tests
├── dotnet/               # .NET adapter source code and tests
└── .github/workflows/    # CI/CD pipelines
```

## Contributing

Please read [CONTRIBUTING.md](./CONTRIBUTING.md) and [CODEOWNERS](./.github/CODEOWNERS) before opening issues or pull requests.

## License

This project is dual-licensed under the [Apache License 2.0](./LICENSE-APACHE) and the [MIT License](./LICENSE-MIT). See [LICENSE](./LICENSE) for details.
