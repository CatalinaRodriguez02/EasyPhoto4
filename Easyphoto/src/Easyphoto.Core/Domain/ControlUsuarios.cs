using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class ControlUsuarios
    {
        public int IdControlU { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Accion { get; set; }
        public int IdUsuarios { get; set; }
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
        public string Rol { get; set; }
        public string Contraseña { get; set; }
        public string ImagenPerfil { get; set; }
    }
}
