using Takid.Application;
using Takid.Infrastructure;

namespace Takid.Api.Extensions;

public static class Extensions
{
    public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddPresentationLayer()
            .AddApplicationLayer()
            .AddInfrastructureLayer(builder.Configuration);

        return builder;
    }
}