using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Puestos
    {
        public int idPuesto { get; set; }
        public int idSucursal { get; set; }
        public string sucursal { get; set; }
        public string nom_suc { get; set; }
        public string nombre { get; set; }
        public string status { get; set; }
        public bool seleccionado { get; set; }
    }
}
