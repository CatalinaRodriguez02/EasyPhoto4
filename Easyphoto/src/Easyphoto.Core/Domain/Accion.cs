using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Accion
    {
        public Accion()
        {
            RolAccion = new HashSet<RolAccion>();
        }

        public int IdAccion { get; set; }
        public string Accion1 { get; set; }
        public int Modulo { get; set; }

        public virtual Modulo ModuloNavigation { get; set; }
        public virtual ICollection<RolAccion> RolAccion { get; set; }
    }
}
