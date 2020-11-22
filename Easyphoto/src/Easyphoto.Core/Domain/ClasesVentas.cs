using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class ClasesVentas
    {
        public ClasesVentas()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdVenta { get; set; }
        public string TipoVenta { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
