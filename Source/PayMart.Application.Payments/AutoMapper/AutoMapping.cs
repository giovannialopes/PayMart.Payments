using AutoMapper;
using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Request;
using PayMart.Domain.Payments.Response;

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
        CreateMap<RequestPostPayment, Payment>();
    }

    public void EntityToResponse()
    {
        CreateMap<Payment, ResponsePostPayment>();
    }
}
