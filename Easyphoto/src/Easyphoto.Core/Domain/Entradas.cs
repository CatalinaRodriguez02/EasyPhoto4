using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Entradas
    {
        public Entradas()
        {
            DetalleEntradas = new HashSet<DetalleEntradas>();
        }

        public int IdEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public double VTotal { get; set; }
        public double? Descuento { get; set; }
        public double? Abono { get; set; }
        public double? Saldo { get; set; }
        public double? Iva { get; set; }

        public virtual Proveedores IdProveedorNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
        public virtual Pagos Pagos { get; set; }
        public virtual ICollection<DetalleEntradas> DetalleEntradas { get; set; }
    }
}
