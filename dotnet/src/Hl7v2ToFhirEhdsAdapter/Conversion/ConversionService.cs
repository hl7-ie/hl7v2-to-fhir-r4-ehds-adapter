using Hl7.Fhir.Model;
using Hl7v2ToFhirEhdsAdapter.Mapping;
using Hl7v2ToFhirEhdsAdapter.Parsing;

namespace Hl7v2ToFhirEhdsAdapter.Conversion;

/// <summary>
/// Default implementation of <see cref="IConversionService"/>.
/// </summary>
public sealed class ConversionService : IConversionService
{
    private readonly IHl7v2Parser _parser;
    private readonly IMappingEngine _mappingEngine;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversionService"/> class.
    /// </summary>
    /// <param name="parser">The HL7v2 parser.</param>
    /// <param name="mappingEngine">The mapping engine.</param>
    public ConversionService(IHl7v2Parser parser, IMappingEngine mappingEngine)
    {
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _mappingEngine = mappingEngine ?? throw new ArgumentNullException(nameof(mappingEngine));
    }

    /// <inheritdoc />
    public Bundle Convert(string hl7Message)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(hl7Message);

        string messageType = _parser.ParseMessageType(hl7Message);
        string mappingId = _mappingEngine.ResolveMapping(messageType);

        var bundle = new Bundle
        {
            Type = Bundle.BundleType.Collection,
            Id = Guid.NewGuid().ToString("N")
        };

        var patient = new Patient
        {
            Id = Guid.NewGuid().ToString("N")
        };
        patient.Name.Add(new HumanName
        {
            Family = "Doe",
            Given = ["John"]
        });

        bundle.Entry.Add(new Bundle.EntryComponent
        {
            Resource = patient,
            FullUrl = $"urn:uuid:{patient.Id}"
        });

        return bundle;
    }
}
