using PayMart.Domain.Payments.Model;

namespace PayMart.Domain.Payments.Services.Post;

public interface IPaymentServices
{
    Task<ModelPayment.ListPaymentResponse?> GetPayments();

    Task<ModelPayment.PaymentResponse?> GetPaymentById(int id);

    Task<ModelPayment.PaymentResponse?> RegisterPayment(ModelPayment.CreatePaymentRequest request);

    bool? ValidatePrice(ModelPayment.CreatePaymentRequest request);

}
