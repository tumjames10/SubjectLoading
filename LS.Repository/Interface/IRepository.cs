using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        T Insert(T entity);

        T Update(T entity);

        T Delete(T entity);

        T Get(T entity);

        T GetByID(int id);

        int SaveChanges();
    }
}
