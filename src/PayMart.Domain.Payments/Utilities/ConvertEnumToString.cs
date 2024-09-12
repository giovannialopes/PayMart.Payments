using PayMart.Domain.Payments.Enums;

namespace PayMart.Domain.Payments.Utilities;

public static class ConvertEnumToString
{
   public static string Convert(this PaymentMethod payment)
    {
        return payment switch
        {
            PaymentMethod.CreditCard => "Cartão de Crédito",
            PaymentMethod.DebitCard => "Cartão de Débito",
            PaymentMethod.PayPal => "Paypal",
            _ => ""
        };
    }
}
