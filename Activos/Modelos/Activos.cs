using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Activos
    {
        public bool seleccionado { get; set; }

        public int idActivo { get; set; }
        public int idArea { get; set; }
        public string area { get; set; }
        public int idTipo { get; set; }
        public string tipo { get; set; }

        public string nombreCorto { get; set; }
        public string descripcion { get; set; }
        public string fechaAlta { get; set; }

        public int? idUsuarioAlta { get; set; }

        public string fechaModificacion { get; set; }

        public int? idUsuarioModifica { get; set; }

        public decimal? costo { get; set; }

        public string numEtiqueta { get; set; }
        public string claveActivo { get; set; }

        public string status { get; set; }

        public string accion { get; set; }
    }

    public partial class ActivosDesc
    {
        public int idActivo { get; set; }

        public int idArea { get; set; }
        public string area { get; set; }
       
        public int idTipo { get; set; }
        public string tipo { get; set; }

        public string nombreCorto { get; set; }
        public string descripcion { get; set; }

        public int idSucursal { get; set; }
        public string sucursal { get; set; }

        public string usuario { get; set; }
        public int? idPersona { get; set; }
        public string fecha { get; set; }

        public decimal? costo { get; set; }

        public string numEtiqueta { get; set; }
        public string claveActivo { get; set; }
    }
}
