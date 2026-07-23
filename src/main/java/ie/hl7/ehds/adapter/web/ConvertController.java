package ie.hl7.ehds.adapter.web;

import ca.uhn.fhir.context.FhirContext;
import ie.hl7.ehds.adapter.convert.ConversionService;
import org.hl7.fhir.r4.model.Bundle;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 * REST controller for HL7v2 to FHIR R4 conversion.
 */
@RestController
@RequestMapping("/api/v1/convert")
public class ConvertController {

    private final ConversionService conversionService;
    private final FhirContext fhirContext;

    /**
     * Creates the controller with required dependencies.
     *
     * @param conversionService the conversion service
     */
    public ConvertController(final ConversionService conversionService) {
        this.conversionService = conversionService;
        this.fhirContext = FhirContext.forR4();
    }

    /**
     * Converts a raw HL7v2 message to a FHIR R4 JSON bundle.
     *
     * @param hl7Message the raw HL7v2 message
     * @return the JSON-serialized FHIR bundle
     */
    @PostMapping(produces = MediaType.APPLICATION_JSON_VALUE)
    public ResponseEntity<String> convert(@RequestBody final String hl7Message) {
        final Bundle bundle = conversionService.convert(hl7Message);
        final String json = fhirContext.newJsonParser().setPrettyPrint(true).encodeResourceToString(bundle);
        return ResponseEntity.ok(json);
    }
}
