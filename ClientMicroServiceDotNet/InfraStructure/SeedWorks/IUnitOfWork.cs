namespace InfraStructure.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangeAsync();
        Task<TResult> ExecuteTransactionAsync<TResult>(Func<Task<TResult>> func);
    }
}
