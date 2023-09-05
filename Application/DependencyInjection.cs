using Application.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Application.Users.Mappings;
using Application.Abstractions;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;


        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

        services.AddScoped(typeof(IPipelineBehavior<,>),typeof(ValidationPipelineBehavior<,>));

        services.AddValidatorsFromAssembly(assembly,includeInternalTypes: true);

        services.AddAutoMapper(typeof(UserMappingProfile));

        return services;
    }
}