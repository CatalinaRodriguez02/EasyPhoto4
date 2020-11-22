using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class PrecioTamañosImp
    {
        public int IdPrecio { get; set; }
        public int Cantidad { get; set; }
        public string Tamaño { get; set; }
        public double PVtaProfesional { get; set; }
        public double PVtaAficionado { get; set; }

        public virtual TamañosImp TamañoNavigation { get; set; }
    }
}
