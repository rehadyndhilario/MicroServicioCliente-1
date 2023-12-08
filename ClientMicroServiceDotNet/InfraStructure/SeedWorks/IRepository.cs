namespace InfraStructure.SeedWorks
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetAsync(int id);
    }
}