using PayMart.Domain.Payments.Enums;

namespace PayMart.Application.Payments.Utilities;

public static class ConvertEnumToString
{
   public static string Convert(this PaymentType payment)
    {
        return payment switch
        {
            PaymentType.CreditCard => "Cartão de Crédito",
            PaymentType.DebitCard => "Cartão de Débito",
            PaymentType.Pix => "Pix",
            PaymentType.Ticket => "Boleto Bancário",
            _ => ""
        };
    }
}
