using FluentAssertions;
using Hl7v2ToFhirEhdsAdapter.Mapping;
using Xunit;

namespace Hl7v2ToFhirEhdsAdapter.Tests;

public class MappingEngineTests
{
    private readonly MappingEngine _engine = new();

    [Fact]
    public void ResolveMapping_ReplacesCaretWithUnderscore()
    {
        _engine.ResolveMapping("ADT^A01").Should().Be("ADT_A01");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void ResolveMapping_WithBlankInput_ReturnsUnknown(string? input)
    {
        _engine.ResolveMapping(input!).Should().Be("unknown");
    }
}
