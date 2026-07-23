namespace Hl7v2ToFhirEhdsAdapter.Mapping;

/// <summary>
/// Resolves declarative mappings for HL7v2 message types.
/// </summary>
public interface IMappingEngine
{
    /// <summary>
    /// Resolves the mapping identifier for a given message type.
    /// </summary>
    /// <param name="messageType">The HL7v2 message type (e.g. <c>ADT^A01</c>).</param>
    /// <returns>The mapping identifier.</returns>
    string ResolveMapping(string messageType);
}
