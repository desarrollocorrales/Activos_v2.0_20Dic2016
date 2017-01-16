using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Personas
    {
        public bool seleccionado { get; set; }
        public int idPersona { get; set; }
        public string nombreCompleto { get; set; }
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
        public int idPuesto { get; set; }
        public string puesto { get; set; }
        public string sucursal { get; set; }
        public string status { get; set; }
    }
}
