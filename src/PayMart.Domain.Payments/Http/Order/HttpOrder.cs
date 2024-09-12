using PayMart.Domain.Payments.Model;
using System.Text.Json;

namespace PayMart.Domain.Payments.Http.Order;

public class HttpOrder
{
    private static HttpClient _http;

    static HttpOrder()
    {
        _http = new HttpClient();
    }

    public static async Task GetOrderByID(ModelPayment.CreatePaymentRequest request)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
        var host = environment == "Development" ? "localhost" : "paymart-orders";

        var httpResponse = await _http.GetStringAsync($"http://{host}:5003/api/Order/getID/{request.OrderId}");
        request.OrderPrice = FormatterGetByID(httpResponse).Price;
    }


    public static OrderResponse FormatterGetByID(string json)
    {
        using var jsonDocument = JsonDocument.Parse(json);
        var order = jsonDocument.RootElement;

        var ordersResponses = new OrderResponse
        {
            Id = order.GetProperty("id").GetInt32(),
            OrderDate = order.GetProperty("orderDate").GetDateTime(),
            Status = order.GetProperty("status").GetString() ?? string.Empty,
            Price = order.GetProperty("price").GetDecimal()
        };

        return ordersResponses;
    }
}
