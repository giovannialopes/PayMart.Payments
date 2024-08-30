using PayMart.Domain.Payments.Enums;

namespace PayMart.Domain.Payments.Entities;

public class Payment
{
    public int Id { get; set; }
    public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.CreditCard;
    public DateTime PaymentDate { get; set; } = DateTime.Now;
    public decimal AmountPaid { get; set; }
    public int OrderId { get; set; } 
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending; 
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public int CreatedBy { get; set; } 
    public int UpdatedBy { get; set; }
    public int DeleteBy { get; set; } 
}
