using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public LSContext DbContext { get; set; }

        public BaseRepository(LSContext context)
        {
            DbContext = context;
        }

        public T Insert(T entity)
        {
            DbContext.Set<T>().Add(entity);
            return entity;
        }

        public T Update(int id, T entity)
        {
            var found = DbContext.Set<T>().Find(id);

            if (found != null)
                DbContext.Entry(found).CurrentValues.SetValues(entity);
            else
                throw new KeyNotFoundException();

            return entity;
        }

        public T Delete(T entity)
        {
            var found = DbContext.Find<T>(entity);

            if (found != null)
                DbContext.Set<T>().Remove(entity);
            else
                throw new KeyNotFoundException();

            return entity;
        }

        public T Get(T entity)
        {
            return DbContext.Set<T>().Find(entity);
        }

        public virtual T GetByID(int id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>>? param = null)
        {
            if (param != null)
            {
                return DbContext.Set<T>().Where(param);
            }
            else
            {
                return DbContext.Set<T>();
            }
        }
    }
}
