using itSenseBL.Interfaces;
using itSenseDomain.Entidades;
using itSensePersistencia.Interfaces;
using itSensePersistencia.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace pruebaItsense.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        protected readonly IProductoBL _productoBL;

        public ProductsController(IProductoBL productoBL)
        {
            _productoBL = productoBL;
        }

        [HttpGet("GetAllProductos")]
        public IActionResult GetAllProducts()
        {
            try
            {
                var productos = _productoBL.GetAllProductos();
                return this.Ok(productos);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var producto = _productoBL.GetProducto(id);
                return this.Ok(producto);
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex);
            }
        }


        [HttpPost("AddProducto")]
        public IActionResult AddProducto([FromBody] Producto producto)
        {
            try
            {
                _productoBL.AddProducto(producto);
                return this.Ok();
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpPut("UpdateProducto")]
        public IActionResult UpdateProducto([FromBody] Producto producto)
        {
            try
            {
                _productoBL.UpdateProducto(producto);
                return this.Ok();
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex);
            }
        }

        [HttpDelete("DeleteProducto/{id}")]
        public IActionResult DeleteProducto(int id)
        {
            try
            {
                _productoBL.DeleteProducto(id);
                return this.Ok();
            }
            catch(Exception ex)
            {
                return this.BadRequest(ex);
            }
        }
    }
}
