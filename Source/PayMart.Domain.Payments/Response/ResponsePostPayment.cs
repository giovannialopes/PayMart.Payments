
using PayMart.Domain.Payments.Enums;

namespace PayMart.Domain.Payments.Response;

public class ResponsePostPayment
{
    public PaymentType PaymentType { get; set; }
    public decimal Price { get; set; }
    public int OrderID { get; set; }
}
