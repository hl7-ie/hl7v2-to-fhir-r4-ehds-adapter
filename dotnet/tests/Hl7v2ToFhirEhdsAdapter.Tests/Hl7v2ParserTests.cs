using FluentAssertions;
using Hl7v2ToFhirEhdsAdapter.Parsing;
using Xunit;

namespace Hl7v2ToFhirEhdsAdapter.Tests;

public class Hl7v2ParserTests
{
    private readonly Hl7v2Parser _parser = new();

    [Theory]
    [InlineData(null, "UNKNOWN")]
    [InlineData("", "UNKNOWN")]
    [InlineData("   ", "UNKNOWN")]
    public void ParseMessageType_WithBlankInput_ReturnsUnknown(string? input, string expected)
    {
        string result = _parser.ParseMessageType(input!);
        result.Should().Be(expected);
    }

    [Fact]
    public void ParseMessageType_WithNonBlankInput_ReturnsDefault()
    {
        string result = _parser.ParseMessageType("MSH|^~\\&|");
        result.Should().Be("ADT^A01");
    }
}
