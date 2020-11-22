using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class PapelFotografico
    {
        public PapelFotografico()
        {
            TamañosImp = new HashSet<TamañosImp>();
        }

        public int IdPapel { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Embalaje { get; set; }
        public int LongCant { get; set; }

        public virtual Productos IdProductoNavigation { get; set; }
        public virtual ICollection<TamañosImp> TamañosImp { get; set; }
    }
}
