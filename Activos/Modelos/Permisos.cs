using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Permisos
    {
        public int idPermiso { get; set; }
        public string descripcion { get; set; }
        public int padreId { get; set; }
    }
}
