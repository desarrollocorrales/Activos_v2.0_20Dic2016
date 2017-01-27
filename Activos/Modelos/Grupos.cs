using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Grupos
    {
        public bool seleccionado { get; set; }

        public int idGrupo { get; set; }

        public int idSucursal { get; set; }
        public string sucursal { get; set; }

        public int idArea { get; set; }
        public string area { get; set; }
        
        public string nombre { get; set; }
        public string fecha { get; set; }
        
        public int idUsuarioCrea { get; set; }
        public string usuarioCrea { get; set; }
        
        public string status { get; set; }
    }
}
