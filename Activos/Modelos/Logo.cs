using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class Logo
    {
        public int idLogo { get; set; }
        public byte[] logo { get; set; }
        public string descripcion { get; set; }
        public string clave { get; set; }
        public string fecha { get; set; }
        public string observaciones { get; set; }
        public string status { get; set; }
        public string nombre { get; set; }

        public Modelos.UsoLogos uso { get; set; }

    }
}
