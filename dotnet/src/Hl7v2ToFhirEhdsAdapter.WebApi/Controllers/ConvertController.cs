using Hl7.Fhir.Serialization;
using Hl7v2ToFhirEhdsAdapter.Conversion;
using Microsoft.AspNetCore.Mvc;

namespace Hl7v2ToFhirEhdsAdapter.WebApi.Controllers;

/// <summary>
/// API controller for HL7v2 to FHIR R4 conversion.
/// </summary>
[ApiController]
[Route("api/v1/convert")]
public class ConvertController : ControllerBase
{
    private readonly IConversionService _conversionService;
    private readonly FhirJsonSerializer _serializer;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConvertController"/> class.
    /// </summary>
    /// <param name="conversionService">The conversion service.</param>
    public ConvertController(IConversionService conversionService)
    {
        _conversionService = conversionService ?? throw new ArgumentNullException(nameof(conversionService));
        _serializer = new FhirJsonSerializer(new SerializerSettings { Pretty = true });
    }

    /// <summary>
    /// Converts a raw HL7v2 message to a FHIR R4 JSON bundle.
    /// </summary>
    /// <param name="hl7Message">The raw HL7v2 message.</param>
    /// <returns>The JSON-serialized FHIR bundle.</returns>
    [HttpPost]
    [Consumes("application/x-www-form-urlencoded", "text/plain")]
    [Produces("application/json")]
    public async Task<IActionResult> Convert([FromForm] string hl7Message)
    {
        var bundle = _conversionService.Convert(hl7Message);
        string json = await _serializer.SerializeToStringAsync(bundle).ConfigureAwait(false);
        return Content(json, "application/json");
    }
}
