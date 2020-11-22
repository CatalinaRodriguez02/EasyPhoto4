using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class DetalleEntradas
    {
        public int IdDetalleEntrada { get; set; }
        public int IdEntrada { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public double SubTotal { get; set; }

        public virtual Entradas IdEntradaNavigation { get; set; }
        public virtual Productos IdProductoNavigation { get; set; }
    }
}
