using Microsoft.AspNetCore.Mvc;
using PayMart.Domain.Payments.Exceptions;
using PayMart.Domain.Payments.Http.Order;
using PayMart.Domain.Payments.Model;
using PayMart.Domain.Payments.Services.Post;
using PayMart.Domain.Payments.Utilities;

namespace PayMart.API.Payments.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    [HttpPost]
    [Route("post/{orderID}/{userID}")]
    public async Task<IActionResult> RegisterPayment(
        [FromServices] IPaymentServices services,
        [FromBody] ModelPayment.CreatePaymentRequest request,
        [FromRoute] int orderID,
        [FromRoute] int userID)
    {
        RegisterRouteInRequest.Register(orderID, userID, request);
        await HttpOrder.GetOrderByID(request);

        var validatePrice = services.ValidatePrice(request);
        if (validatePrice == true)
        {
            var registerPayment = await services.RegisterPayment(request);
            if (registerPayment == null)
                return Ok(ResourceExceptions.PAGAMENTO_JÁ_EXISTENTE);

            return Ok(registerPayment);
        }
        return Ok(ResourceExceptions.NAO_ATINGIU_PAGAMENTO);
    }
}
