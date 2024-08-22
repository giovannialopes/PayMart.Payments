using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Payments.UseCases.Post;
using PayMart.Domain.Payments.Request;

namespace PayMart.API.Payments.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpPost]
    [Route("post/{price}/{ProductID}")]
    public async Task<IActionResult> Post(
        [FromServices] IPostPaymentUseCases useCases,
        [FromBody] RequestPostPayment request,
        [FromRoute]decimal price, int productID)
    {
        request.OrderID = productID;
        request.Price = price;

        var response = await useCases.Execute(request);
        return Ok(response);
    }
}
