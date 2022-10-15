using itSenseDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itSenseBL.Interfaces
{
    public interface IProductoBL
    {
        public Producto GetProducto(int id);
        public List<Producto> GetAllProductos();
        public List<Producto> GetAllProductosFiltrados(FiltroProducto filtro); 
        public void AddProducto(Producto producto);
        public void UpdateProducto(Producto producto);
        public void DeleteProducto(int id);
    }
}
