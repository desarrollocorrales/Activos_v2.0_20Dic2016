using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IActivosDatos
    {
        bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario);
    }
}
