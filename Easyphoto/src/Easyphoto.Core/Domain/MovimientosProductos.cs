using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class MovimientosProductos
    {
        public int Id { get; set; }
        public string ProductoOServicio { get; set; }
        public decimal? Cantidad { get; set; }
        public double ValorUnitario { get; set; }
        public double? Total { get; set; }
    }
}
