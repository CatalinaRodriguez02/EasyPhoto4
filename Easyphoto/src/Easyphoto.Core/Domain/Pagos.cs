using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Pagos
    {
        public int IdEntrada { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int IdProveedor { get; set; }
        public int IdUsuario { get; set; }
        public double? Saldo { get; set; }

        public virtual Entradas IdEntradaNavigation { get; set; }
        public virtual Proveedores IdProveedorNavigation { get; set; }
        public virtual Usuarios IdUsuarioNavigation { get; set; }
    }
}
