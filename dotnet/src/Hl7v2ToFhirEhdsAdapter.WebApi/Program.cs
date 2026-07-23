using Hl7v2ToFhirEhdsAdapter.Conversion;
using Hl7v2ToFhirEhdsAdapter.Mapping;
using Hl7v2ToFhirEhdsAdapter.Parsing;

namespace Hl7v2ToFhirEhdsAdapter.WebApi;

public partial class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddSingleton<IHl7v2Parser, Hl7v2Parser>();
        builder.Services.AddSingleton<IMappingEngine, MappingEngine>();
        builder.Services.AddSingleton<IConversionService, ConversionService>();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddHealthChecks();

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.MapHealthChecks("/health");
        app.MapControllers();

        app.Run();
    }
}
