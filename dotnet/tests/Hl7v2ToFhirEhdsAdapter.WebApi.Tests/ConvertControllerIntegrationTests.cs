using System.Net;
using System.Net.Mime;
using FluentAssertions;
using Xunit;

namespace Hl7v2ToFhirEhdsAdapter.WebApi.Tests;

public class ConvertControllerIntegrationTests : IClassFixture<WebApiFactory>
{
    private readonly HttpClient _client;

    public ConvertControllerIntegrationTests(WebApiFactory factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Convert_WithFormEncodedMessage_ReturnsJsonBundle()
    {
        var content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["hl7Message"] = "MSH|^~\\&|TEST"
        });

        var response = await _client.PostAsync("/api/v1/convert", content);

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        response.Content.Headers.ContentType!.MediaType.Should().Be(MediaTypeNames.Application.Json);
        string body = await response.Content.ReadAsStringAsync();
        body.Should().Contain("\"resourceType\": \"Bundle\"");
    }

    [Fact]
    public async Task HealthEndpoint_ReturnsOk()
    {
        var response = await _client.GetAsync("/health");
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
}
