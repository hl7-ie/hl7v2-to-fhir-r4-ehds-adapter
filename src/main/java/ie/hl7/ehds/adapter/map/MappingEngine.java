package ie.hl7.ehds.adapter.map;

import org.springframework.stereotype.Component;

/**
 * Applies declarative mappings from HL7v2 message types to FHIR R4 resources.
 *
 * <p>This is a placeholder implementation. Future iterations will load
 * FHIR Mapping Language (FML) or YAML mapping definitions from
 * {@code classpath:/mappings}.</p>
 */
@Component
public class MappingEngine {

    /**
     * Resolves the mapping identifier for a given message type.
     *
     * @param messageType the HL7v2 message type (e.g. {@code ADT^A01})
     * @return the mapping identifier
     */
    public String resolveMapping(final String messageType) {
        return messageType == null ? "unknown" : messageType.replace('^', '_');
    }
}
