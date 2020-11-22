using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Productos
    {
        public Productos()
        {
            DetalleEntradas = new HashSet<DetalleEntradas>();
            DetalleOrdenCompra = new HashSet<DetalleOrdenCompra>();
            PapelFotografico = new HashSet<PapelFotografico>();
        }

        public int IdProducto { get; set; }
        public int? IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public double PVtaProfesional { get; set; }
        public double PVtaAficionado { get; set; }
        public double? Cantidad { get; set; }
        public string ImgProducto { get; set; }

        public virtual GruposProductos IdGrupoNavigation { get; set; }
        public virtual ICollection<DetalleEntradas> DetalleEntradas { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompra { get; set; }
        public virtual ICollection<PapelFotografico> PapelFotografico { get; set; }
    }
}
