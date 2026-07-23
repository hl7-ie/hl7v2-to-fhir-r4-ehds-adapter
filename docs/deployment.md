# Deployment

## Runtime Requirements

- Java Runtime Environment 17 or higher
- Network access to FHIR terminology services (if validation is enabled)

## Running Locally

```bash
./scripts/build.sh
java -jar target/hl7v2-to-fhir-r4-ehds-adapter-*.jar
```

## Configuration

Configuration is externalized via Spring Boot `application.yml`:

```yaml
adapter:
  mappings:
    directory: classpath:/mappings
  fhir:
    profiles:
      directory: classpath:/fhir/profiles
    validate: true
  hl7v2:
    ack-enabled: true
```

## Docker (Planned)

A `Dockerfile` and `docker-compose.yml` will be added for containerized deployment.

## Kubernetes (Planned)

Helm charts and deployment manifests for cloud/on-prem Kubernetes clusters.
