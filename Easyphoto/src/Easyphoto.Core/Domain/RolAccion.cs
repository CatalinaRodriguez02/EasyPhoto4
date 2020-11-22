using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class RolAccion
    {
        public int Id { get; set; }
        public int IdRol { get; set; }
        public int IdAccion { get; set; }

        public virtual Accion IdAccionNavigation { get; set; }
        public virtual Rol IdRolNavigation { get; set; }
    }
}
