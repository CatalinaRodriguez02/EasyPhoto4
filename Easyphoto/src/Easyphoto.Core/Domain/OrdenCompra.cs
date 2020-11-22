using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class OrdenCompra
    {
        public OrdenCompra()
        {
            DetalleOrdenCompra = new HashSet<DetalleOrdenCompra>();
            Entregas = new HashSet<Entregas>();
        }

        public int IdOrden { get; set; }
        public int ConscFactura { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public double VTotal { get; set; }
        public double? Descuento { get; set; }
        public double? Abono { get; set; }
        public double? Saldo { get; set; }
        public double? Iva { get; set; }

        public virtual Factura ConscFacturaNavigation { get; set; }
        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompra { get; set; }
        public virtual ICollection<Entregas> Entregas { get; set; }
    }
}
