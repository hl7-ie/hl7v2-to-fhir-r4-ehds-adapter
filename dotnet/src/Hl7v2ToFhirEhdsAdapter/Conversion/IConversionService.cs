using Hl7.Fhir.Model;

namespace Hl7v2ToFhirEhdsAdapter.Conversion;

/// <summary>
/// Converts raw HL7v2 messages into FHIR R4 bundles.
/// </summary>
public interface IConversionService
{
    /// <summary>
    /// Converts the supplied HL7v2 message to a FHIR R4 bundle.
    /// </summary>
    /// <param name="hl7Message">The raw HL7v2 message.</param>
    /// <returns>A non-null FHIR R4 bundle.</returns>
    Bundle Convert(string hl7Message);
}
