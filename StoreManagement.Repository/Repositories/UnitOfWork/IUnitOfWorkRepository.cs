namespace StoreManagement.Repository.Repositories.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        Task<int> SaveChangesAsync();
    }
}