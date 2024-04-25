using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

using Domain.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _dbContext;

        public RepositoryBase(RepositoryContext dbContext) => _dbContext = dbContext;

        
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
              _dbContext.Set<T>()
                .AsNoTracking() :
            _dbContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
              _dbContext.Set<T>()
                .Where(expression)
                .AsNoTracking() :
            _dbContext.Set<T>()
                .Where(expression);


        public void Create(T entity) => _dbContext.Set<T>().Add(entity);

        public void Update(T entity) => _dbContext.Set<T>().Update(entity);

        public void Delete(T entity) => _dbContext.Set<T>().Remove(entity);
    }
}
