using SoftBreak.Onion.APPLICATION.DTOs;
using SoftBreak.Onion.DOMAIN.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SoftBreak.Onion.APPLICATION.Managers
{
    public interface IManager<D,T> where D : class,IEntity where T : class,IDto
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> WhereAsync(Expression<Func<D, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<D, bool>> exp);

        bool AnyAsync(Expression<Func<D, bool>> exp);

        Task<string> CreateAsync(T entity);
        Task<string> UpdateAsync(T entity);
        Task<string> DeleteAsync(T entity);
        Task<string> RemoveAsync(T entity);
    }
}
