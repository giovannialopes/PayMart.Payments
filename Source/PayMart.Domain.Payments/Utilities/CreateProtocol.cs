namespace PayMart.Domain.Payments.Utilities;

public static class CreateProtocol
{
    public static string Create()
    {
        string dataHora = DateTime.Now.ToString("yyyyMMdd-HHmmss");
        string guid = Guid.NewGuid().ToString().Split('-')[0]; 
        string protocolo = $"{dataHora}-{guid}";

        return protocolo;
    }
}
