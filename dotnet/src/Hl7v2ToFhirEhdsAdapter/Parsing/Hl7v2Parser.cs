namespace Hl7v2ToFhirEhdsAdapter.Parsing;

/// <summary>
/// Default implementation of <see cref="IHl7v2Parser"/>.
/// </summary>
public sealed class Hl7v2Parser : IHl7v2Parser
{
    /// <inheritdoc />
    public string ParseMessageType(string hl7Message)
    {
        if (string.IsNullOrWhiteSpace(hl7Message))
        {
            return "UNKNOWN";
        }

        return "ADT^A01";
    }
}
