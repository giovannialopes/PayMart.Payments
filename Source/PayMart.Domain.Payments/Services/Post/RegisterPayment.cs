using AutoMapper;
using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Repositories;
using PayMart.Domain.Payments.Model;

namespace PayMart.Domain.Payments.Services.Post;

public class RegisterPayment(IPaymentRepository paymentRepository,
    IMapper mapper) : IRegisterPayment
{
    public async Task<ModelPayment.PaymentResponse?> Execute(ModelPayment.CreatePaymentRequest request)
    {
        var Payment = mapper.Map<Payment>(request);

        if (Payment != null)
        {
            Payment.CreatedBy = request.UserId;
            await paymentRepository.Add(Payment);

            await paymentRepository.Commit();

            return mapper.Map<ModelPayment.PaymentResponse>(Payment);
        }
        return default;
    }
}
