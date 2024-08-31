using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Database;

namespace PayMart.Domain.Payments.Interface.Repositories;

public interface IPaymentRepository : ICommit
{
    Task Add(Payment payment);

    Task<bool?> VerifyExistingPayment(int orderId);
}
