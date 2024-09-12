using PayMart.Domain.Payments.Enums;
using System.Text.Json.Serialization;

namespace PayMart.Domain.Payments.Model;

public class ModelPayment
{
    public class CreatePaymentRequest
    {
        public int OrderId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public decimal AmountPaid { get; set; }

        [JsonIgnore]
        public decimal OrderPrice { get; set; }
        [JsonIgnore]
        public int UserId { get; set; }
    }

    public class UpdatePaymentRequest
    {
        public int Id { get; set; }
        public decimal AmountPaid { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus Status { get; set; }
    }

    public class PaymentResponse
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public decimal AmountPaid { get; set; }
        public string Protocol {  get; set; } = string.Empty;
    }

    public class ListPaymentResponse
    {
        public List<PaymentResponse> Payments { get; set; } = [];
    }
}
