package ie.hl7.ehds.adapter.convert;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertNotNull;
import static org.junit.jupiter.api.Assertions.assertTrue;

import java.io.IOException;
import java.nio.charset.StandardCharsets;
import org.hl7.fhir.r4.model.Bundle;
import org.hl7.fhir.r4.model.Patient;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.core.io.ClassPathResource;
import org.springframework.util.StreamUtils;

/**
 * Integration test for {@link ConversionService} using sample HL7v2 messages.
 */
@SpringBootTest
class ConversionServiceIntegrationTest {

    @Autowired
    private ConversionService conversionService;

    @Test
    void convertSampleAdtA01ReturnsBundleWithPatient() throws IOException {
        final String hl7Message = StreamUtils.copyToString(
            new ClassPathResource("messages/adt_a01.hl7").getInputStream(), StandardCharsets.UTF_8);

        final Bundle bundle = conversionService.convert(hl7Message);

        assertNotNull(bundle);
        assertEquals(Bundle.BundleType.COLLECTION, bundle.getType());
        assertTrue(bundle.getEntry().stream().anyMatch(e -> e.getResource() instanceof Patient));
    }
}
