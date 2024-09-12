using static PayMart.Domain.Payments.Model.ModelPayment;

namespace PayMart.Domain.Payments.Utilities;

public class RegisterRouteInRequest()
{

    static RegisterRouteInRequest() { }


    public  static void Register(int orderId, int userID, CreatePaymentRequest request) { 
    
        request.UserId = userID;
        request.OrderId = orderId;
    }

}
