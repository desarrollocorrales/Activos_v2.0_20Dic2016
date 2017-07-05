using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Traspasos
    {
        public bool seleccionado { get; set; }
        public int consecTraspaso { get; set; }

        public int idPersonaAnt { get; set; }
        public string personaAnt { get; set; }

        public int idPersonaNuevo { get; set; }
        public string personaNuevo { get; set; }

        public string fecha { get; set; }
        public string motivo { get; set; }
    }

    public class TraspasosDetallado
    {
        public bool seleccionado { get; set; }
        public long idCambio { get; set; }
        public int consecTraspaso { get; set; }

        public int idPersonaAnt { get; set; }
        public string personaAnt { get; set; }

        public int idAreaAnt { get; set; }
        public string areaAnt { get; set; }

        public int idPersonaNuevo { get; set; }
        public string personaNuevo { get; set; }

        public int idAreaNueva { get; set; }
        public string areaNueva { get; set; }

        public string fecha { get; set; }
        public string motivo { get; set; }
        public int idActivo { get; set; }
    }
}
