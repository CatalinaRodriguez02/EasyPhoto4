using System;
using System.Collections.Generic;

namespace Easyphoto.Core.Domain
{
    public partial class ProductosStockBajos
    {
        public int IdProducto { get; set; }
        public int? IdGrupo { get; set; }
        public string Descripcion { get; set; }
        public double PVtaProfesional { get; set; }
        public double PVtaAficionado { get; set; }
        public double? Cantidad { get; set; }
        public string ImgProducto { get; set; }
    }
}
