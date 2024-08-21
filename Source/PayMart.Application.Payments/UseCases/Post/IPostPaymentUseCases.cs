using PayMart.Domain.Payments.Request;
using PayMart.Domain.Payments.Response;

namespace PayMart.Application.Payments.UseCases.Post;

public interface IPostPaymentUseCases
{
    Task<ResponsePostPayment> Execute(RequestPostPayment request);
}
