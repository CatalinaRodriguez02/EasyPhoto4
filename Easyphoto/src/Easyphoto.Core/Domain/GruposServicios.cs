using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class GruposServicios
    {
        public GruposServicios()
        {
            Servicios = new HashSet<Servicios>();
        }

        public int IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }

        public virtual ICollection<Servicios> Servicios { get; set; }
    }
}
