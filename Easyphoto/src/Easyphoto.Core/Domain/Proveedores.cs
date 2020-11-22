using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Entradas = new HashSet<Entradas>();
            Pagos = new HashSet<Pagos>();
        }

        public int IdProveedores { get; set; }
        public string Nit { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string ImagenLogo { get; set; }

        public virtual ICollection<Entradas> Entradas { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
    }
}
