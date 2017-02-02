using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Responsivas
    {
        public int idResponsiva { get; set; }
        public int idPersona { get; set; }
        public int idUsuarioCrea { get; set; }

        public string fecha { get; set; }
        public string fechaBaja { get; set; }
        public string observaciones { get; set; }
        public string status { get; set; }

        public string sucursal { get; set; }
        public string puesto { get; set; }
        public string responsable { get; set; }

        public string fechaImpresion { get; set; }
    }

    public partial class RespDetalle
    {
        public int idResponsivaDet { get; set; }
        public int idResponsiva { get; set; }

        public int idActivo { get; set; }
        public string activo { get; set; }
        public string numEtiqueta { get; set; }
        public string claveActivo { get; set; }

        public decimal? costo { get; set; }
        public string status { get; set; }

    }
}
