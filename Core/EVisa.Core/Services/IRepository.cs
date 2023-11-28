using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Core.Services
{
    public interface IRepository<T> where T : class
    {
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        IQueryable<T> GetAll();
        void SaveChangesAsync();
    }
}
