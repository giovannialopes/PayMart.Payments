using PayMart.Domain.Payments.Request;
using PayMart.Domain.Payments.Response;

namespace PayMart.Application.Payments.UseCases.Post;

public class PostPaymentUseCases : IPostPaymentUseCases
{
    public PostPaymentUseCases()
    {
        
    }

    public Task<ResponsePostPayment> Execute(RequestPostPayment request)
    {
        throw new NotImplementedException();
    }
}
