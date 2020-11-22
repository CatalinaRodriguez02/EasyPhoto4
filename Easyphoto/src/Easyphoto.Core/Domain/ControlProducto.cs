using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class ControlProducto
    {
        public int IdControlP { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Accion { get; set; }
        public int IdProducto { get; set; }
        public int? IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public double PVtaProfesional { get; set; }
        public double PVtaAficionado { get; set; }
        public double? Cantidad { get; set; }
        public string ImagenProducto { get; set; }
    }
}
