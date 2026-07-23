package ie.hl7.ehds.adapter.map;

import static org.junit.jupiter.api.Assertions.assertEquals;

import org.junit.jupiter.api.Test;

/**
 * Tests for {@link MappingEngine}.
 */
class MappingEngineTest {

    private final MappingEngine engine = new MappingEngine();

    @Test
    void resolveMappingReplacesCaretWithUnderscore() {
        assertEquals("ADT_A01", engine.resolveMapping("ADT^A01"));
    }

    @Test
    void resolveMappingReturnsUnknownForNullInput() {
        assertEquals("unknown", engine.resolveMapping(null));
    }
}
