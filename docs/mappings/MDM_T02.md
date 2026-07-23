# MDM^T02 Mapping

## Scope

Maps `MDM^T02` (Medical Document Management) to FHIR R4 resources:
- `Patient`
- `DocumentReference`
- `Practitioner`

## Segment Mapping Summary

| HL7v2 Segment | FHIR Resource | Notes |
|---------------|---------------|-------|
| `PID`         | `Patient`     | Patient identity |
| `TXA`         | `DocumentReference` | Document metadata |
| `OBX`         | `Observation` / attachment | Document content |

## Example

TBD: Add sample HL7v2 message and expected FHIR output.

## EHDS Profile Alignment

TBD: Reference EHDS profile URLs and constraints.
