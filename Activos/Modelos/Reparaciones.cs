using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Reparaciones
    {
        public int idReparacion { get; set; }

        public int idActivo { get; set; }
        public string activo { get; set; }

        public int idUsuarioResp { get; set; }
        public string usuario { get; set; }

        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public string causa { get; set; }
        public string status { get; set; }
    }
}
