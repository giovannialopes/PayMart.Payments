using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Payments.Entities;

namespace PayMart.Infrastructure.Payments.DataBase;

public class DbPayments : DbContext
{
    public DbPayments(DbContextOptions options) : base(options) { }

    public DbSet<Payment> Tb_Payment {  get; set; }

}
