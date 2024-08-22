
namespace PayMart.Domain.Payments.Response;

public class ResponsePostPayment
{
    public string PaymentType { get; set; } = "";
    public DateTime DateTime { get; set; }
    public decimal Price { get; set; }
}
