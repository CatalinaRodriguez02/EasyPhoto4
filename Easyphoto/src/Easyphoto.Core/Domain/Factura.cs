using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Factura
    {
        public Factura()
        {
            Entregas = new HashSet<Entregas>();
            OrdenCompra = new HashSet<OrdenCompra>();
        }

        public int ConscFactura { get; set; }
        public int IdVenta { get; set; }
        public double? Efectivo { get; set; }
        public double? Tarjeta { get; set; }

        public virtual ClasesVentas IdVentaNavigation { get; set; }
        public virtual ICollection<Entregas> Entregas { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompra { get; set; }
    }
}
