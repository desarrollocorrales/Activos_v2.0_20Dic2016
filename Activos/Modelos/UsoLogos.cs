using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Modelos
{
    public class UsoLogos
    {
        public UsoLogos(int idUso, string clave, string nombre)
        {
            this.clave = clave;
            this.idUso = idUso;
            this.nombre = nombre;
        }

        public int idUso { get; set; }
        public string clave { get; set; }

        public string nombre { get; set; }
    }
}
