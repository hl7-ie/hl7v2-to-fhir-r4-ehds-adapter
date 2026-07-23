namespace Hl7v2ToFhirEhdsAdapter.Mapping;

/// <summary>
/// Default implementation of <see cref="IMappingEngine"/>.
/// </summary>
public sealed class MappingEngine : IMappingEngine
{
    /// <inheritdoc />
    public string ResolveMapping(string messageType)
    {
        return string.IsNullOrWhiteSpace(messageType) ? "unknown" : messageType.Replace('^', '_');
    }
}
