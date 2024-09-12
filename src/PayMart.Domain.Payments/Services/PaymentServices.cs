using AutoMapper;
using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Repositories;
using PayMart.Domain.Payments.Model;
using PayMart.Domain.Payments.Services.Post;
using PayMart.Domain.Payments.Utilities;

namespace PayMart.Domain.Payments.Services;

public class PaymentServices(IPaymentRepository paymentRepository,
    IMapper mapper) : IPaymentServices
{
    public async Task<ModelPayment.ListPaymentResponse?> GetPayments()
    {
        var response = await paymentRepository.GetPayments();
        if (response!.Count != 0)
            return new ModelPayment.ListPaymentResponse { Payments = mapper.Map<List<ModelPayment.PaymentResponse>>(response) };

        return default;
    }

    public async Task<ModelPayment.PaymentResponse?> GetPaymentById(int id)
    {
        var response = await paymentRepository.GetPaymentById(id);
        if (response != null)
        {
            return mapper.Map<ModelPayment.PaymentResponse>(response);
        }
        return default;
    }

    public async Task<ModelPayment.PaymentResponse?> RegisterPayment(ModelPayment.CreatePaymentRequest request)
    {
        var verifyPayment = await paymentRepository.VerifyExistingPayment(request.OrderId);
        if (verifyPayment == false)
        {
            var Payment = mapper.Map<Payment>(request);
            if (Payment != null)
            {
                Payment.CreatedBy = request.UserId;
                Payment.Protocol = CreateProtocol.Create();

                await paymentRepository.Add(Payment);
                await paymentRepository.Commit();

                return mapper.Map<ModelPayment.PaymentResponse>(Payment);
            }
        }
        return default;
    }

    public bool? ValidatePrice(ModelPayment.CreatePaymentRequest request)
    {
        if (request.AmountPaid == request.OrderPrice)
            return true;
        return false;
    }
}
