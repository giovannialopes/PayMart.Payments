using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Database;

namespace PayMart.Domain.Payments.Interface.Repositories;

public interface IPaymentRepository : ICommit
{
    Task<List<Payment>?> GetPayments();

    Task<Payment?> GetPaymentById(int id);

    Task Add(Payment payment);

    Task<bool?> VerifyExistingPayment(int orderId);
}
