using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Sucursales
    {
        public bool seleccionado { get; set; }
        public int idSucursal { get; set; }
        public string nombre { get; set; }
        public int? idResponsable { get; set; }
        public string responsable { get; set; }
        public string status { get; set; }
    }
}
