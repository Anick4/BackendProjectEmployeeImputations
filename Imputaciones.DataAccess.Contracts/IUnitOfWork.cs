namespace Imputaciones.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
