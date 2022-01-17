using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WE_Test.Repository.Contract
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetAllEmps();
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
