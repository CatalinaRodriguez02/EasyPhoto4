using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Servicios
    {
        public Servicios()
        {
            DetalleOrdenCompra = new HashSet<DetalleOrdenCompra>();
        }

        public int IdServicio { get; set; }
        public int? IdGrupo { get; set; }
        public string Combo { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public virtual GruposServicios IdGrupoNavigation { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompra { get; set; }
    }
}
