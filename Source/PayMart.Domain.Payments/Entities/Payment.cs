using PayMart.Domain.Payments.Enums;

namespace PayMart.Domain.Payments.Entities;

public class Payment
{
    public int Id { get; set; }
    public PaymentType PaymentType { get; set; }

    public int OrderID {  get; set; }
}
