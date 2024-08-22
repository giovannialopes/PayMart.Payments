using PayMart.Domain.Payments.Enums;
using System.Text.Json.Serialization;

namespace PayMart.Domain.Payments.Request;

public class RequestPostPayment
{
    public PaymentType PaymentType { get; set; }




    [JsonIgnore]
    public decimal Price { get; set; }
    [JsonIgnore]
    public int OrderID { get; set; }



}
