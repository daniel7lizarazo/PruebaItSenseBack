using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itSensePersistencia.Interfaces
{
    public interface IRepositorio<T> 
        where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> expression);
        T GetByID(int id);
        void AddEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteById(int id);
        void UpdateEntity(T entity);
    }
}
