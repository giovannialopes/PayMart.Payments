using Microsoft.EntityFrameworkCore;

namespace PayMart.Infrastructure.Payments.DataBase;

public class DbPayments : DbContext
{
    public DbPayments(DbContextOptions options) : base(options) { }

    public DbSet<>

}
