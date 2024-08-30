using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Repositories;
using PayMart.Infrastructure.Payments.DataBase;

namespace PayMart.Infrastructure.Payments.Repositories;

public class PaymentRepository(DbPayments payments) : IPaymentRepository
{
    public async Task Commit() => await payments.SaveChangesAsync();

    public async Task Add(Payment payment) => await payments.Tb_Payment.AddAsync(payment);

}
