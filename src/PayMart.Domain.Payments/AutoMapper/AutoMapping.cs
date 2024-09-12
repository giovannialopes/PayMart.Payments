using AutoMapper;
using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Model;

namespace PayMart.Application.Payments.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }

    public void RequestToEntity()
    {
        CreateMap<ModelPayment.CreatePaymentRequest, Payment>();
    }

    public void EntityToResponse()
    {
        CreateMap<Payment, ModelPayment.PaymentResponse>();
    }
}
