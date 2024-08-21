using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Infrastructure.Payments.DataBase;

namespace PayMart.Infrastructure.Payments.Migrations;

public static class DataBaseMigration 
{
    public async static Task MigrateDataBase(this IServiceProvider service)
    {
        var db = service.GetRequiredService<DbPayments>();
        await db.Database.MigrateAsync();
    }


}
