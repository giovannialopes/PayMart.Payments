using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Payments.AutoMapper;
using PayMart.Application.Payments.UseCases.Post;

namespace PayMart.Application.Payments.Injection;

public static class DependencyInjectionApp
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddRepositories(services);
        AutoMapper(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IPostPaymentUseCases, PostPaymentUseCases>();
    }

    private static void AutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }
}
