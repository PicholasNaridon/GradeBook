using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GradeBook.Services
{

    public interface IGenericRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    public abstract class EntityBase
    {
        public int Id
        {
            get;
            set;
        }
        public DateTime AddedDate
        {
            get;
            set;
        }
        public DateTime ModifiedDate
        {
            get;
            set;
        }
        public string IPAddress
        {
            get;
            set;
        }
    }
}
