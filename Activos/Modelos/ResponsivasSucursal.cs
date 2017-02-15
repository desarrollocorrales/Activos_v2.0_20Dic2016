using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class ResponsivasSucursal
    {
        public int idPersona { get; set; }
        public int idResponsiva { get; set; } // folio
        public int idActivo { get; set; }

        public string persona { get; set; }

        public string activo { get; set; }
        public string descripcion { get; set; }

        public string estatus { get; set; }
    }
}
