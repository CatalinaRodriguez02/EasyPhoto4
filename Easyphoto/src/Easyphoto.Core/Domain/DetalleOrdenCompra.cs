using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class DetalleOrdenCompra
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public int IdServicio { get; set; }
        public int? IdTamañoImp { get; set; }
        public int Cantidad { get; set; }
        public double VUnitario { get; set; }
        public double SubTotal { get; set; }

        public virtual OrdenCompra IdOrdenNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
        public virtual Servicios IdServicioNavigation { get; set; }
        public virtual TamañosImp IdTamañoImpNavigation { get; set; }
    }
}
