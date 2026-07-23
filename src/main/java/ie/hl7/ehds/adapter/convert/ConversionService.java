package ie.hl7.ehds.adapter.convert;

import ca.uhn.fhir.model.primitive.IdDt;
import org.hl7.fhir.r4.model.Bundle;
import org.hl7.fhir.r4.model.Patient;
import org.springframework.stereotype.Service;

/**
 * Service responsible for converting HL7v2 messages into FHIR R4 bundles.
 */
@Service
public class ConversionService {

    /**
     * Performs a minimal conversion of an HL7v2 message to a FHIR R4 collection bundle.
     *
     * <p>This is a smoke-test implementation that always returns a bundle containing
     * a placeholder Patient resource.</p>
     *
     * @param hl7Message the raw HL7v2 message
     * @return a non-null FHIR R4 bundle
     */
    public Bundle convert(final String hl7Message) {
        final Bundle bundle = new Bundle();
        bundle.setType(Bundle.BundleType.COLLECTION);

        final Patient patient = new Patient();
        patient.setId(IdDt.newRandomUuid());
        patient.addName().setFamily("Doe").addGiven("John");

        bundle.addEntry().setResource(patient);
        return bundle;
    }
}
