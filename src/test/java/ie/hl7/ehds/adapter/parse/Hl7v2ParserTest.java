package ie.hl7.ehds.adapter.parse;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;

/**
 * Tests for {@link Hl7v2Parser}.
 */
class Hl7v2ParserTest {

    private final Hl7v2Parser parser = new Hl7v2Parser();

    @Test
    void parseMessageTypeReturnsUnknownForBlankInput() {
        assertEquals("UNKNOWN", parser.parseMessageType(null));
        assertEquals("UNKNOWN", parser.parseMessageType(""));
        assertEquals("UNKNOWN", parser.parseMessageType("   "));
    }

    @Test
    void parseMessageTypeReturnsDefaultForNonBlankInput() {
        assertEquals("ADT^A01", parser.parseMessageType("MSH|^~\\&|"));
    }
}
