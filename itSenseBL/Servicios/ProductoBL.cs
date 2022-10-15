using itSenseBL.Interfaces;
using itSenseDomain.Entidades;
using itSensePersistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace itSenseBL.Servicios
{
    public class ProductoBL : IProductoBL
    {
        protected readonly IUnitOfWork _unitOfWork;
        public ProductoBL(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddProducto(Producto producto)
        {
            _unitOfWork.Productos.AddEntity(producto);
            _unitOfWork.Complete();
        }

        public void DeleteProducto(int id)
        {
            _unitOfWork.Productos.DeleteById(id);
            _unitOfWork.Complete();
        }

        public List<Producto> GetAllProductos()
        {
            return _unitOfWork.Productos.GetAll().ToList();
        }

        public List<Producto> GetAllProductosFiltrados(FiltroProducto filtro)
        {
            Expression<Func<Producto, bool>> expresion = producto =>
                                                    (filtro.Nombre == null || producto.Nombre == filtro.Nombre)
                                                    && (filtro.EsDefectuoso == null || producto.EsDefectuoso == filtro.EsDefectuoso)
                                                    && (filtro.Stock == null || producto.Stock == filtro.Stock)
                                                    && (filtro.EstadoProducto == null || producto.EstadoProducto == filtro.EstadoProducto);

            return _unitOfWork.Productos.GetByCondition(expresion).ToList();
        }

        public Producto GetProducto(int id)
        {
            return _unitOfWork.Productos.GetByID(id);
        }

        public void UpdateProducto(Producto producto)
        {
            _unitOfWork.Productos.UpdateEntity(producto);
            _unitOfWork.Complete();
        }
    }
}
