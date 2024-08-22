using AutoMapper;
using PayMart.Application.Payments.Utilities;
using PayMart.Domain.Payments.Entities;
using PayMart.Domain.Payments.Interface.Database;
using PayMart.Domain.Payments.Interface.Payment.Post;
using PayMart.Domain.Payments.Request;
using PayMart.Domain.Payments.Response;

namespace PayMart.Application.Payments.UseCases.Post;

public class PostPaymentUseCases : IPostPaymentUseCases
{
    private readonly ICommit _commit;
    private readonly IPost _post;
    private readonly IMapper _mapper;

    public PostPaymentUseCases(ICommit commit,
        IPost post,
        IMapper mapper)
    {
        _commit = commit;
        _post = post;
        _mapper = mapper;
    }

    public async Task<ResponsePostPayment> Execute(RequestPostPayment request)
    {
        var Payment = _mapper.Map<Payment>(request);

        await _post.Add(Payment);

        await _commit.Commit();

        return _mapper.Map<ResponsePostPayment>(Payment);

    }
}
