# AGENTS.md

Guidance for Copilot agents and human contributors working on the **HL7v2 to FHIR R4 EHDS Adapter**.

## Project purpose

This repository implements an adapter that converts [HL7 Version 2](https://hl7.org/implement/standards/product_brief.cfm?product_id=185) (HL7v2) messages into [FHIR R4](https://hl7.org/fhir/R4/) resources, aligned with the European Health Data Space (EHDS) requirements.

The goal is to provide a reliable, testable, and standards-compliant conversion layer that can be integrated into health data exchange workflows.

## Working conventions

### Language and tooling

- Prefer the language and build toolchain chosen by the repository maintainers.
- Keep dependencies minimal and well-justified.
- Use the project's configured linters, formatters, and test runners. Run them before committing.

### Code style

- Write clear, self-documenting code.
- Follow existing naming conventions and project structure.
- Keep functions and modules focused on a single responsibility.
- Prefer immutable data structures and pure functions where practical.

### Healthcare and standards awareness

- This project deals with clinical data. Treat data privacy and security as first-class concerns.
- Do not log, store, or expose protected health information (PHI/ePHI) unless explicitly required and appropriately safeguarded.
- Follow HL7 and FHIR conventions for resource naming, identifiers, coding systems, and value sets.
- When mapping HL7v2 fields to FHIR elements:
  - Reference official HL7v2-to-FHIR implementation guides where applicable.
  - Prefer explicit, verifiable mappings over assumptions.
  - Document any deviations or extensions with clear rationale.

### Testing

- Add or update tests for every behavior change.
- Include representative HL7v2 message fixtures and expected FHIR outputs.
- Aim for high coverage of mapping logic, edge cases, and error handling.

### Documentation

- Update README, mapping documentation, and inline comments when changing behavior.
- Document new message types, resources, or configuration options.
- Keep examples in documentation runnable and accurate.

### Security

- Do not commit secrets, API keys, tokens, or credentials.
- Avoid introducing dependencies with known vulnerabilities.
- Validate inputs and fail safely; never assume HL7v2 messages are well-formed or benign.
- Be cautious with deserialization, parsing, and external data handling.

## Suggested workflow

1. Understand the mapping or feature being changed.
2. Add tests that reflect the expected behavior.
3. Implement the minimal change to satisfy the tests.
4. Run the full test suite and linting checks.
5. Update documentation and examples as needed.
6. Commit with a clear, descriptive message.

## Useful references

- [HL7 FHIR R4](https://hl7.org/fhir/R4/)
- [HL7 Version 2 Product Suite](https://hl7.org/implement/standards/product_brief.cfm?product_id=185)
- [European Health Data Space (EHDS)](https://health.ec.europa.eu/ehealth-digital-health-and-care/european-health-data-space_en)

## License

This project is released under the MIT License. See [LICENSE](./LICENSE) for details.
