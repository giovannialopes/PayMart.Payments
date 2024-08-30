using PayMart.Domain.Payments.Enums;
using System.Text.Json.Serialization;

namespace PayMart.Domain.Payments.Model;

public class ModelPayment
{
    public class CreatePaymentRequest
    {
        public PaymentMethod PaymentMethod { get; set; }
        public int OrderId { get; set; }
        public PaymentStatus Status { get; set; }

        [JsonIgnore]
        public int UserId { get; set; }

        [JsonIgnore]
        public decimal AmountPaid { get; set; }
    }

    public class UpdatePaymentRequest
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentStatus Status { get; set; }
    }

    public class PaymentResponse
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public int OrderId { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
