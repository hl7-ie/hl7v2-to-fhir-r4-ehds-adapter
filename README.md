# HL7v2 to FHIR R4 EHDS Adapter

[![CI](https://github.com/hl7-ie/hl7v2-to-fhir-r4-ehds-adapter/actions/workflows/ci.yml/badge.svg)](https://github.com/hl7-ie/hl7v2-to-fhir-r4-ehds-adapter/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](./LICENSE)

A reusable, enterprise-ready adapter for converting HL7v2 messages used by the **European Health Data Space (EHDS)** specifications into **FHIR R4** resources and bundles.

## Goals

- Provide a standards-based bridge between legacy HL7v2 feeds and FHIR R4 endpoints.
- Ship declarative, versioned, profile-aware mappings aligned with EHDS requirements.
- Expose both a REST API and a command-line interface for flexible deployment.
- Enforce code quality, security scanning, and automated FHIR validation in CI.

## Technology Stack

- **Runtime**: Java 17, Spring Boot 3.2
- **HL7v2 Parsing**: HAPI HL7v2
- **FHIR Model & Validation**: HAPI FHIR R4
- **Build**: Apache Maven
- **Quality**: Checkstyle, SpotBugs, OWASP Dependency-Check

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

```bash
./scripts/build.sh
```

Or directly with Maven:

```bash
mvn clean verify
```

## Test

```bash
./scripts/test.sh
```

## Usage

The project exposes a Spring Boot application. After building:

```bash
java -jar target/hl7v2-to-fhir-r4-ehds-adapter-*.jar
```

REST endpoints and CLI usage will be documented as they are implemented.

## Project Structure

```
├── docs/              # Architecture, deployment, and mapping documentation
├── config/            # Quality and security tool configurations
├── scripts/           # Build and test helper scripts
├── src/main/java/     # Adapter source code
├── src/main/resources/# Mappings, FHIR profiles, and HL7v2 segment metadata
└── .github/workflows/ # CI/CD pipelines
```

## Contributing

Please read [CONTRIBUTING.md](./CONTRIBUTING.md) and [CODEOWNERS](./.github/CODEOWNERS) before opening issues or pull requests.

## License

This project is licensed under the [MIT License](./LICENSE).
