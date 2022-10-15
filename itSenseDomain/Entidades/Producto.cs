using itSenseDomain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace itSenseDomain.Entidades
{
    [Table("products")]
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La cantidad del producto es requerida")]
        [MaxLength(100, ErrorMessage = "La longitud del nombre no debe superar los 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La cantidad del producto es requerida")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "El valor de es defectuoso es requerido")]
        public bool EsDefectuoso { get; set; }
        [Required(ErrorMessage ="El estado del producto es necesario")]
        public EnumEstadosProducto EstadoProducto { get; set; }
    }
}
