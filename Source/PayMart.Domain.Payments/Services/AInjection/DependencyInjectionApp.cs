using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Payments.AutoMapper;
using PayMart.Domain.Payments.Services.Post;

namespace PayMart.Domain.Payments.Services.AInjection;

public static class DependencyInjectionApp
{
    public static void AddServices(this IServiceCollection services)
    {
        AddRepositories(services);
        AutoMapper(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IPaymentServices, PaymentService>();
    }

    private static void AutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }
}
