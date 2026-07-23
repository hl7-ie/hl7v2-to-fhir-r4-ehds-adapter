package ie.hl7.ehds.adapter.parse;

import org.springframework.stereotype.Component;

/**
 * Parses raw HL7v2 messages into an internal canonical representation.
 *
 * <p>This is a placeholder implementation. Future iterations will use
 * HAPI HL7v2 to parse segments and fields.</p>
 */
@Component
public class Hl7v2Parser {

    /**
     * Placeholder parse method.
     *
     * @param hl7Message the raw HL7v2 message
     * @return the message type, or {@code UNKNOWN} if not determinable
     */
    public String parseMessageType(final String hl7Message) {
        if (hl7Message == null || hl7Message.isBlank()) {
            return "UNKNOWN";
        }
        return "ADT^A01";
    }
}
