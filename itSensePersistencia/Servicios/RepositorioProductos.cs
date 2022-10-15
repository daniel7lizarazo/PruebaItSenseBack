using itSenseDomain.Entidades;
using itSenseDomain.Enums;
using itSensePersistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itSensePersistencia.Servicios
{
    public class RepositorioProductos : Repositorio<Producto>, IRepositorioProductos
    {
        public RepositorioProductos(ApplicationContext appContext) : base(appContext)
        {
        }
    }
}
