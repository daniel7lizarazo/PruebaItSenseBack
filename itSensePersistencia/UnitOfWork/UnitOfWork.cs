using itSensePersistencia.Interfaces;
using itSensePersistencia.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itSensePersistencia.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationContext _appContext;
        public UnitOfWork(ApplicationContext appContext)
        {
            _appContext = appContext;
            Productos = new RepositorioProductos(_appContext);
        }

        public IRepositorioProductos Productos { get; private set; }

        public int Complete()
        {
            return _appContext.SaveChanges();
        }

        public void Dispose()
        {
            _appContext.Dispose();
        }
    }
}
