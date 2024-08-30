using Microsoft.AspNetCore.Mvc;
using PayMart.Domain.Payments.Model;
using PayMart.Domain.Payments.Services.Post;

namespace PayMart.API.Payments.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpPost]
    [Route("post/{price}")]
    public async Task<IActionResult> Post(
        [FromServices] IRegisterPayment services,
        [FromBody] ModelPayment.CreatePaymentRequest request,
        [FromRoute]decimal price, int productID, int userID)
    {
        request.OrderId = productID;
        request.AmountPaid = price;
        request.UserId = userID;

        var response = await services.Execute(request);
        return Ok(response);
    }
}
