using PayMart.Domain.Payments.Model;

namespace PayMart.Domain.Payments.Services.Post;

public interface IRegisterPayment
{
    Task<ModelPayment.PaymentResponse?> Execute(ModelPayment.CreatePaymentRequest request);
}
