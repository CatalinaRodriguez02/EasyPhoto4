using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Modulo
    {
        public Modulo()
        {
            Accion = new HashSet<Accion>();
        }

        public int IdModulo { get; set; }
        public string Modulo1 { get; set; }

        public virtual ICollection<Accion> Accion { get; set; }
    }
}
