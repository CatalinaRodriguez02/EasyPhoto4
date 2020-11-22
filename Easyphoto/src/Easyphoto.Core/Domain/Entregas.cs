using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Entregas
    {
        public int IdEntrega { get; set; }
        public int IdOrden { get; set; }
        public int ConscFactura { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public double? Saldo { get; set; }
        public double? Iva { get; set; }

        public virtual Factura ConscFacturaNavigation { get; set; }
        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual OrdenCompra IdOrdenNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
