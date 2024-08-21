using PayMart.Domain.Payments.Enums;

namespace PayMart.Domain.Payments.Request;

public class RequestPostPayment
{
    public PaymentType PaymentType { get; set; }

}
