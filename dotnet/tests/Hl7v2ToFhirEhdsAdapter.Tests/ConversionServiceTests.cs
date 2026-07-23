using FluentAssertions;
using Hl7.Fhir.Model;
using Hl7v2ToFhirEhdsAdapter.Conversion;
using Hl7v2ToFhirEhdsAdapter.Mapping;
using Hl7v2ToFhirEhdsAdapter.Parsing;
using Xunit;

namespace Hl7v2ToFhirEhdsAdapter.Tests;

public class ConversionServiceTests
{
    private readonly ConversionService _service;

    public ConversionServiceTests()
    {
        _service = new ConversionService(new Hl7v2Parser(), new MappingEngine());
    }

    [Fact]
    public void Convert_WithValidMessage_ReturnsCollectionBundle()
    {
        var bundle = _service.Convert("MSH|^~\\&|TEST");

        bundle.Should().NotBeNull();
        bundle.Type.Should().Be(Bundle.BundleType.Collection);
        bundle.Entry.Should().ContainSingle();
        bundle.Entry[0].Resource.Should().BeOfType<Patient>();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Convert_WithInvalidMessage_ThrowsArgumentException(string? message)
    {
        Action act = () => _service.Convert(message!);
        act.Should().Throw<ArgumentException>();
    }
}
