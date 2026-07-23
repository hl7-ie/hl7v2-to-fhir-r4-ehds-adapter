# Contributing to HL7v2 to FHIR R4 EHDS Adapter

Thank you for your interest in contributing. This document outlines the process for proposing changes and reporting issues.

## How to Contribute

1. **Open an issue** describing the bug, feature, or mapping gap.
2. **Fork the repository** and create a feature branch.
3. **Make focused changes** with clear commit messages.
4. **Run the full build** locally using `./scripts/build.sh`.
5. **Open a pull request** and fill in the template details.

## Development Setup

- Java 17+
- Apache Maven 3.9+
- (Optional) Docker for local integration tests

## Code Standards

- Follow the [Google Java Style Guide](https://google.github.io/styleguide/javaguide.html) as enforced by Checkstyle.
- Keep mappings versioned and documented in `docs/mappings/`.
- Add unit tests for new mapping logic.
- Do not commit secrets, credentials, or large binary files.

## Security

Security-sensitive changes must pass SpotBugs and OWASP Dependency-Check scans. Report vulnerabilities privately to the maintainers listed in [CODEOWNERS](./.github/CODEOWNERS).
