using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        T Insert(T entity);

        T Update(int id, T entity);

        T Delete(T entity);

        T Get(T entity);

        T GetByID(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>>? param = null);

        int SaveChanges();
    }
}
