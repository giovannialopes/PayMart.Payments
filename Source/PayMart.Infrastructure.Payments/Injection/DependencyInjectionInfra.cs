using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Infrastructure.Payments.DataBase;

namespace PayMart.Infrastructure.Payments.Injection;

public static class DependencyInjectionInfra
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        DbContext(services, configuration);
    }

    public static void DbContext(IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<DbPayments>(config => config.UseSqlServer(connectionString));
    }
}
