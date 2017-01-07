using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IReparacionesNegocio
    {
        List<Modelos.Reparaciones> getBuscaActivosReparacion(int idTipo, string nombre);
    }
}
