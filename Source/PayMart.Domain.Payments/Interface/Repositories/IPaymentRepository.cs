using PayMart.Domain.Payments.Interface.Database;

namespace PayMart.Domain.Payments.Interface.Repositories;

public interface IPaymentRepository : ICommit
{
    Task Add(Entities.Payment payment);
}
