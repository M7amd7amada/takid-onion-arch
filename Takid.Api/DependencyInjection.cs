using Microsoft.AspNetCore.Mvc.Infrastructure;
using Takid.Api.Common.Errors;
using Takid.Api.Common.Mapping;

namespace Takid.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentationLayer(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory, AppProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}