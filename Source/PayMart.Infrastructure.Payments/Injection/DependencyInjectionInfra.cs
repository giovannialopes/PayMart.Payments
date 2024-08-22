using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Payments.Interface.Database;
using PayMart.Domain.Payments.Interface.Payment.Post;
using PayMart.Infrastructure.Payments.DataBase;
using PayMart.Infrastructure.Payments.Repositories;

namespace PayMart.Infrastructure.Payments.Injection;

public static class DependencyInjectionInfra
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        DbContext(services, configuration);
        AddRepositories(services);
    }

    public static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IPost, PaymentRepository>();
    }

    public static void DbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICommit, PaymentRepository>();

        var connectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<DbPayments>(config => config.UseSqlServer(connectionString));
    }
}
