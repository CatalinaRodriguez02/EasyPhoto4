using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class Clientes
    {
        public Clientes()
        {
            Entregas = new HashSet<Entregas>();
            OrdenCompra = new HashSet<OrdenCompra>();
        }

        public int IdCliente { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public int? TipoCliente { get; set; }
        public string Contraseña { get; set; }
        public string ImagenLogo { get; set; }

        public virtual Rol TipoClienteNavigation { get; set; }
        public virtual ICollection<Entregas> Entregas { get; set; }
        public virtual ICollection<OrdenCompra> OrdenCompra { get; set; }
    }
}
