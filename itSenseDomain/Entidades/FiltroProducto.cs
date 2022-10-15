using itSenseDomain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itSenseDomain.Entidades
{
    public class FiltroProducto
    {
        public string? Nombre { get; set; }
        public int? Stock { get; set; }
        public bool? EsDefectuoso { get; set; }
        public EnumEstadosProducto? EstadoProducto { get; set; }
    }
}
