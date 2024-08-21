namespace PayMart.Domain.Payments.Interface.Database;

public interface ICommit
{
    Task Commit();
}
