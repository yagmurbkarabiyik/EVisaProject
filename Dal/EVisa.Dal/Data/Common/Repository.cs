using EVisa.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dal.Data.Common
{
    public class Repository<T, TDbContext> : IRepository<T> where T : class
                                                           where TDbContext : DbContext
    {
        protected readonly TDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(TDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }


        public async Task InsertAsync(T entity)
        {
           await  _dbSet.AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<TResult?> GetAsync<TResult>(Expression<Func<T, TResult>> projection, Expression<Func<T, bool>> filter)
        {
            return await _dbSet.Where(filter).Select(projection).FirstOrDefaultAsync();
        }


        public void UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> Get()
        {
            throw new NotImplementedException();
        }

		public void SaveChangesAsync()
		{
			_dbContext.SaveChanges();
		}
	}
}
