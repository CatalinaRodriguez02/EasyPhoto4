using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Rol
    {
        public Rol()
        {
            Clientes = new HashSet<Clientes>();
            RolAccion = new HashSet<RolAccion>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdRol { get; set; }
        public string Rol1 { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<RolAccion> RolAccion { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
