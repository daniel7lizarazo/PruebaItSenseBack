using itSenseDomain.Entidades;
using itSensePersistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itSensePersistencia.Servicios
{
public class Repositorio<T> : IRepositorio<T> 
        where T : class
    {
        protected readonly ApplicationContext _appContext;
        public Repositorio(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public void AddEntity(T entity)
        {
            _appContext.Set<T>().Add(entity);
        }

        public T GetByID(int id)
        {
            return _appContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _appContext.Set<T>().ToList();
        }

        public IEnumerable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return _appContext.Set<T>().Where(expression);
        }

        public void UpdateEntity(T entity)
        {
            _appContext.Set<T>().Update(entity);
        }

        public void DeleteEntity(T entity)
        {
            _appContext.Set<T>().Remove(entity);
        }

        public void DeleteById(int id)
        {
            var producto = _appContext.Set<T>().Find(id);
            if(producto != null)
            {
                _appContext.Set<T>().Remove(producto);
            }
        }
    }
}
