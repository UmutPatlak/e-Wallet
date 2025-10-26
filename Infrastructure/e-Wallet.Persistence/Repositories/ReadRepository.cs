using e_Wallet.Application.Interfaces.Repositories;
using e_Wallet.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace e_Wallet.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext dbContext;

        public ReadRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private DbSet<T> Table => dbContext.Set<T>();

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false)
        {
            IQueryable<T> query = Table;
            if (!enableTracking) query = query.AsNoTracking();
            if (include is not null) query = include(query);
            if (predicate is not null) query = query.Where(predicate);
            if (orderBy is not null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public async Task<List<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 5)
        {
            IQueryable<T> query = Table;
            if (!enableTracking) query = query.AsNoTracking();
            if (include is not null) query = include(query);
            if (predicate is not null) query = query.Where(predicate);
            if (orderBy is not null)
                query = orderBy(query);

            return await query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> query = Table;
            if (!enableTracking) query = query.AsNoTracking();
            if (include is not null) query = include(query);

            return await query.FirstOrDefaultAsync(predicate);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            IQueryable<T> query = Table;
            if (!enableTracking) query = query.AsNoTracking();
            return query.Where(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            IQueryable<T> query = Table;
            if (predicate is not null) query = query.Where(predicate);
            return await query.CountAsync();
        }
    }
}