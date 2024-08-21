using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Payments.UseCases.Post;
using PayMart.Domain.Payments.Request;

namespace PayMart.API.Payments.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpPost]
    [Route("post")]
    public async Task<IActionResult> Post(
        [FromServices] IPostPaymentUseCases useCases,
        [FromBody] RequestPostPayment request)
    {
        var response = await useCases.Execute(request);
        return Ok(response);
    }
}
