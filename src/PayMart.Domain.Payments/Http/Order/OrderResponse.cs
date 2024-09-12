namespace PayMart.Domain.Payments.Http.Order;

public class OrderResponse
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; } = string.Empty;
}
