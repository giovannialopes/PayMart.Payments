
namespace PayMart.Domain.Payments.Interface.Payment.Post;

public interface IPost
{
    Task Add(Entities.Payment payment);
}
