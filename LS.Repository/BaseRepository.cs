using LS.Model;
using LS.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly LSContext dbContext;

        public BaseRepository(LSContext context)
        {
            dbContext = context;
        }

        public T Insert(T entity)
        {
            dbContext.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            var found = dbContext.Find<T>(entity);

            if (found != null)
                dbContext.Update(entity);
            else
                throw new KeyNotFoundException();

            return entity;
        }

        public T Delete(T entity)
        {
            var found = dbContext.Find<T>(entity);

            if (found != null)
                dbContext.Remove(entity);
            else
                throw new KeyNotFoundException();

            return entity;
        }

        public T Get(T entity)
        {
            var found = dbContext.Find<T>(entity);

            if (found != null)
                return found;
            else
                return null;
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }
    }
}
