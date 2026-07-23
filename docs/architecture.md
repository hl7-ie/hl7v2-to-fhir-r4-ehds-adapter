# Architecture

## Overview

The adapter accepts HL7v2 messages, parses them, applies declarative mappings, and emits FHIR R4 resources or bundles.

## High-Level Flow

```
+-------------+      +----------------+      +------------------+      +----------------+
| HL7v2 Feed  |----->| HL7v2 Parser    |----->| Mapping Engine   |----->| FHIR Bundle    |
| (MLLP/HTTP/ |      | (HAPI HL7v2)    |      | (FML / Config)   |      | Builder        |
| File/CLI)   |      +----------------+      +------------------+      +----------------+
+-------------+                                                        |
                                                                       v
                                                               +----------------+
                                                               | FHIR Validator |
                                                               | (HAPI FHIR)    |
                                                               +----------------+
```

## Components

### HL7v2 Parser
- Validates message structure.
- Extracts segments and fields into an internal canonical model.
- Generates HL7 ACK messages when required.

### Mapping Engine
- Loads mappings keyed by message type and trigger event.
- Supports FHIR Mapping Language (FML) and YAML-based mapping tables.
- Handles versioning per EHDS release.

### FHIR Bundle Builder
- Produces `Bundle` resources of type `transaction` or `collection`.
- Resolves references between resources (Patient, Encounter, etc.).

### FHIR Validator
- Validates generated resources against EHDS R4 profiles.
- Returns `OperationOutcome` for validation errors.

### API/CLI Layer
- REST endpoints for single-message conversion.
- CLI for batch/file-based conversion and local testing.

## Error Handling

- Parsing errors return HL7 NAK messages or HTTP 400 responses.
- Mapping and validation errors produce structured `OperationOutcome` resources.
- Audit events are logged in a structured format for enterprise traceability.
