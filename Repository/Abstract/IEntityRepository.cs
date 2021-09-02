using EfDemo.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EfDemo.Repository.Abstract
{
    // T yerine gelebilecek kurallar (generic constraint). Ek olarak sadece newlenebilen şeyler koyulabilir.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);

    }
}
