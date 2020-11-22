using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class TamañosImp
    {
        public TamañosImp()
        {
            DetalleOrdenCompra = new HashSet<DetalleOrdenCompra>();
            PrecioTamañosImp = new HashSet<PrecioTamañosImp>();
        }

        public int IdTamañoImp { get; set; }
        public string TamañoImp { get; set; }
        public int? IdPapel { get; set; }
        public decimal? Consume { get; set; }

        public virtual PapelFotografico IdPapelNavigation { get; set; }
        public virtual ICollection<DetalleOrdenCompra> DetalleOrdenCompra { get; set; }
        public virtual ICollection<PrecioTamañosImp> PrecioTamañosImp { get; set; }
    }
}
