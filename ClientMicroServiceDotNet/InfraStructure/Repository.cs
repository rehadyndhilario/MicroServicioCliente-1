using Entity;
using InfraStructure.SeedWorks;
using Microsoft.EntityFrameworkCore;
using System;

namespace InfraStructure
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        private DbSet<T> _dbSet;
        private DbSet<T> DbSet => _dbSet ??= _dbContext.Set<T>();

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public T GetAsync(int id)
        {            
            return DbSet.FirstOrDefault(_ => (_ as EntityBase).Id == id);
        }

        public void Update(T entity)
        {
            DbSet.Update(entity);
        }        
    }
}