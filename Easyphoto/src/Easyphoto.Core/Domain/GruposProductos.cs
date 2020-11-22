using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class GruposProductos
    {
        public GruposProductos()
        {
            Productos = new HashSet<Productos>();
        }

        public int IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
