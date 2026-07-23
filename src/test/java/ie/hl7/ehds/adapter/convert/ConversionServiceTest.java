package ie.hl7.ehds.adapter.convert;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;

import org.hl7.fhir.r4.model.Bundle;
import org.junit.jupiter.api.Test;

/**
 * Tests for {@link ConversionService}.
 */
class ConversionServiceTest {

    private final ConversionService conversionService = new ConversionService();

    @Test
    void convertReturnsCollectionBundle() {
        final Bundle bundle = conversionService.convert("MSH|^~\\&|");

        assertNotNull(bundle, "bundle should not be null");
        assertEquals(Bundle.BundleType.COLLECTION, bundle.getType(), "bundle type should be COLLECTION");
        assertEquals(1, bundle.getEntry().size(), "bundle should contain one entry");
    }
}
