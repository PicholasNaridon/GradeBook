using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GradeBook.Services
{
    public interface IGenericRepository<T, T1> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindBy(T1 id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T1 id);
        void Save();
    }
}
