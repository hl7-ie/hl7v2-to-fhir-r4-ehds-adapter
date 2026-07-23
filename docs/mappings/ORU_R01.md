# ORU^R01 Mapping

## Scope

Maps `ORU^R01` (Unsolicited Observation Message) to FHIR R4 resources:
- `Patient`
- `Encounter`
- `Observation`
- `DiagnosticReport`

## Segment Mapping Summary

| HL7v2 Segment | FHIR Resource | Notes |
|---------------|---------------|-------|
| `PID`         | `Patient`     | Patient identity |
| `OBR`         | `DiagnosticReport` | Order/result group |
| `OBX`         | `Observation` | Individual observation |

## Example

TBD: Add sample HL7v2 message and expected FHIR output.

## EHDS Profile Alignment

TBD: Reference EHDS profile URLs and constraints.
