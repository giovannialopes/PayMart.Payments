using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Database;
using PayMart.Domain.Payments.Interface.Payment.Post;
using PayMart.Infrastructure.Payments.DataBase;

namespace PayMart.Infrastructure.Payments.Repositories;

public class PaymentRepository:
    ICommit,
    IPost
{
    private readonly DbPayments _dbPayments;
    public PaymentRepository(DbPayments payments)
    {
        _dbPayments = payments;
    }

    public async Task Add(Payment payment) => await _dbPayments.Tb_Payment.AddAsync(payment);


    public async Task Commit() => await _dbPayments.SaveChangesAsync();

}
