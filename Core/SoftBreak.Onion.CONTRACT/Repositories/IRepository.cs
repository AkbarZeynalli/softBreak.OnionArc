using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SoftBreak.Onion.CONTRACT.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> Where(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> exp);

        bool AnyAsync(Expression<Func<T, bool>> exp);

        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
