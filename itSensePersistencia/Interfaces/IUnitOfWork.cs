using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itSensePersistencia.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositorioProductos Productos { get; }
        int Complete();
    }
}
