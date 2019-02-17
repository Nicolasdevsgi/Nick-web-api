namespace Nick.Web.Infra.Data.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
