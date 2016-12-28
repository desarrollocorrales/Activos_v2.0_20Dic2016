using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Areas
    {
        public bool seleccionado { get; set; }
        public int idArea { get; set; }
        public int idSucursal { get; set; }
        public string sucursal { get; set; }
        public string nombre { get; set; }
        public string status { get; set; }
    }
}
