using Application.Accounts.Mappings;
using Application.Behaviors;
using Application.Categories.Mappings;
using Application.Transactions.Mappings;
using Application.Users.Mappings;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddAplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;


        services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(assembly));

        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

        services.AddValidatorsFromAssembly(assembly, includeInternalTypes: true);

        services.AddAutoMapper(typeof(UserMappingProfile));
        services.AddAutoMapper(typeof(AccountMappingProfile));
        services.AddAutoMapper(typeof(TransactionMappingProfile));
        services.AddAutoMapper(typeof(CategoryMappingProfile));

        return services;
    }
}