using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Cambios
    {
        public int idcambio { get; set; }
        public int idPersonaAnt { get; set; }
        public string personaAnt { get; set; }

        public int idAreaAnterior { get; set; }
        public string areaanterior { get; set; }

        public int idPersonaNuevo { get; set; }
        public string personaNuevo { get; set; }

        public int idAreaNueva { get; set; }
        public string areaNueva { get; set; }

        public string fecha { get; set; }
        public string motivo { get; set; }
        public int idActivo { get; set; }
    }
}
