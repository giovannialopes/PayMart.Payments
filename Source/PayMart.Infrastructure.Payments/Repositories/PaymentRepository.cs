using PayMart.Domain.Payments.Interface.Database;
using PayMart.Infrastructure.Payments.DataBase;

namespace PayMart.Infrastructure.Payments.Repositories;

public class PaymentRepository:
    ICommit
{
    private readonly DbPayments _dbPayments;
    public PaymentRepository(DbPayments payments)
    {
        _dbPayments = payments;
    }

    public async Task Commit() => await _dbPayments.SaveChangesAsync();

}
