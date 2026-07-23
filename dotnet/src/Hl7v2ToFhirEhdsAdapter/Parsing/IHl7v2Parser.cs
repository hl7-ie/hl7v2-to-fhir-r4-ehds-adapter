namespace Hl7v2ToFhirEhdsAdapter.Parsing;

/// <summary>
/// Parses raw HL7v2 messages.
/// </summary>
public interface IHl7v2Parser
{
    /// <summary>
    /// Extracts the message type from the supplied HL7v2 message.
    /// </summary>
    /// <param name="hl7Message">The raw HL7v2 message.</param>
    /// <returns>The message type, or <c>UNKNOWN</c> if not determinable.</returns>
    string ParseMessageType(string hl7Message);
}
