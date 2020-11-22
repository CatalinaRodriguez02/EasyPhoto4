using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class TrabajosEntregados
    {
        public int OrdenNo { get; set; }
        public string FechaYHoraDeCompra { get; set; }
        public string Cliente { get; set; }
        public string Nombres { get; set; }
        public string Vendedor { get; set; }
        public double ValorTotal { get; set; }
        public double? Descuento { get; set; }
        public double? Abono { get; set; }
        public double? Saldo { get; set; }
        public string FechaYHoraDeEntrega { get; set; }
        public string EntregadoPor { get; set; }
        public string Estado { get; set; }
    }
}
