
using F1.Application.Contracts.Persistance;
using F1.Domain.Common;
using F1.Domain.Dto;
using F1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace F1.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T> where T : EntityBase
    {
        protected readonly F1Context _dbContext;

        public RepositoryBase(F1Context dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<BaseCollection<T>> GetAllAsync(int pageNumber, int pageSize)
        {
            // I Can not cast BaseCollection<T> to any specyfic Collection, Not sure how to solve It, so just fore to override this method to get child BaseColletion type.
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                               string includeString = null,
                                               bool dissableTracking = true)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (dissableTracking)
                query = query.AsNoTracking();

            if (!string.IsNullOrEmpty(includeString))
                query = query.Include(includeString);

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate = null,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                List<Expression<Func<T, object>>> includes = null,
                                                bool dissabledTracking = true)
        {
            IQueryable<T> query = _dbContext.Set<T>();

            if (dissabledTracking)
                query = query.AsNoTracking();

            if (includes != null)
                query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
    }
}
